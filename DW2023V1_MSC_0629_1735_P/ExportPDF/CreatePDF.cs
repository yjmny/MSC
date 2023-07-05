using DwLib.Data.Generic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ExportPDF
{
    internal class CreatePDF
    {
        public string filename;
        public static string checkcancel = "";
        public static List<string> ch_num;

        public void ThreadProc()
        {
            SaveFileDialog svg = new SaveFileDialog();
            svg.Title = "PDF 내보내기";
            svg.RestoreDirectory = true;
            svg.FileName = DateTime.Now.ToString("yyyyMMdHHmmssfff") + "_mdata.pdf";
            svg.AutoUpgradeEnabled = false;
            if (svg.ShowDialog() == DialogResult.Cancel)
            {
                checkcancel = "cancel";
                return;
            }
            filename = svg.FileName;


        }
        public void createPDF_test(DataTable MeasureInfo, DataTable RcpInfo, DataTable SampleInfo, DataTable TestResult)
        {

            checkcancel = "ok";
            Thread t = new Thread(ThreadProc);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            if (checkcancel.Equals("cancel"))
            {
                return;
            }
            else if (checkcancel.Equals("ok"))
            {
                List<string> ch12 = new List<string>();
                for (int i = 1; i < 13; i++)
                {
                    ch12.Add(i.ToString("00"));
                }
                Cursor.Current = Cursors.WaitCursor;
                string batangttf = System.IO.Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), @"Fonts\malgun.ttf");
                BaseFont batangBase = BaseFont.CreateFont(batangttf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                var batang = new iTextSharp.text.Font(batangBase, 12F);
                var batang_title = new iTextSharp.text.Font(batangBase, 16F, Font.BOLD);
                var batang_sub_title = new iTextSharp.text.Font(batangBase, 12F, Font.BOLD);


                try
                {
                    int iExportChartOpt = CommonClass.chartOption;
                    SaveChart chart;
                    switch (iExportChartOpt)
                    {
                        default:
                        case 1: chart = new SaveChart(null); break;
                        case 2: chart = new SaveChart(ch12); break;
                        case 3: chart = new SaveChart(ch_num); break;
                        case 4: chart = new SaveChart(ch_num); break;

                    }
                    chart.Show();

                    while (CommonClass.isExportPdfClosed)
                    {

                        Document document = new Document(iTextSharp.text.PageSize.A4);

                        using (FileStream stream1 = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            PdfWriter writer = PdfWriter.GetInstance(document, stream1);
                            string printTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            writer.PageEvent = new HeaderFooter(printTime);
                            document.Open();

                            iTextSharp.text.Image chart1 = iTextSharp.text.Image.GetInstance("chart1.png");
                            chart1.ScalePercent(80f);
                            chart1.ScaleAbsoluteHeight(450f);
                            chart1.RotationDegrees = 270;
                            chart1.SetAbsolutePosition(80, 70);

                            //----------각각의 테이블--------------------------------
                            PdfPTable table = new PdfPTable(MeasureInfo.Columns.Count);
                            float[] widths = new float[] { 0.5f, 1f, 2f };
                            table.SetWidths(widths);
                            table.WidthPercentage = 100;

                            PdfPTable table2 = new PdfPTable(RcpInfo.Columns.Count);
                            table2.SetWidths(new float[] { 0.5f, 1f, 2f });
                            table2.WidthPercentage = 100;

                            PdfPTable table3 = new PdfPTable(SampleInfo.Columns.Count);
                            table3.SetWidths(new float[] { 0.5f, 2f, 2f, 2f, 1f, 1f });
                            table3.WidthPercentage = 100;

                            PdfPTable table4 = new PdfPTable(TestResult.Columns.Count);
                            table4.SetWidths(new float[] { 0.5f, 1f, 1f, 1f, 1f });
                            table4.WidthPercentage = 100;


                            //--------테이블 column header
                            for (int k = 0; k < MeasureInfo.Columns.Count; k++)
                            {

                                PdfPCell cell = new PdfPCell(new Phrase(MeasureInfo.Columns[k].ColumnName, batang));

                                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(217, 217, 217);


                                table.AddCell(cell);
                            }
                            for (int k = 0; k < RcpInfo.Columns.Count; k++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(RcpInfo.Columns[k].ColumnName, batang));

                                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(217, 217, 217);


                                table2.AddCell(cell);
                            }
                            for (int k = 0; k < SampleInfo.Columns.Count; k++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(SampleInfo.Columns[k].ColumnName, batang));

                                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(217, 217, 217);


                                table3.AddCell(cell);
                            }
                            for (int k = 0; k < TestResult.Columns.Count; k++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(TestResult.Columns[k].ColumnName, batang));

                                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(217, 217, 217);


                                table4.AddCell(cell);
                            }



                            //--------테이블 row데이터값----------
                            for (int i = 0; i < MeasureInfo.Rows.Count; i++)
                            {
                                for (int j = 0; j < MeasureInfo.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(MeasureInfo.Rows[i][j].ToString(), batang));

                                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                                    cell.FixedHeight = 25;
                                    table.AddCell(cell);
                                }
                            }
                            for (int i = 0; i < RcpInfo.Rows.Count; i++)
                            {
                                for (int j = 0; j < RcpInfo.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(RcpInfo.Rows[i][j].ToString(), batang));

                                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                                    cell.FixedHeight = 25;
                                    table2.AddCell(cell);
                                }
                            }
                            for (int i = 0; i < SampleInfo.Rows.Count; i++)
                            {
                                for (int j = 0; j < SampleInfo.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(SampleInfo.Rows[i][j].ToString(), batang));

                                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                                    cell.FixedHeight = 25;
                                    table3.AddCell(cell);
                                }
                            }
                            for (int i = 0; i < TestResult.Rows.Count; i++)
                            {
                                for (int j = 0; j < TestResult.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(TestResult.Rows[i][j].ToString(), batang));

                                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                                    cell.FixedHeight = 25;
                                    table4.AddCell(cell);
                                }
                            }



                            Paragraph info = new Paragraph(32, "측정정보 ", batang_sub_title);
                            Paragraph sample = new Paragraph(32, "샘플정보 ", batang_sub_title);
                            Paragraph measure = new Paragraph(32, "시험결과 ", batang_sub_title);

                            Phrase empty = new Phrase(5, "     ");
                            Phrase empty30 = new Phrase(30, "     ");
                            Phrase empty60 = new Phrase(60, "     ");

                            document.Add(empty60);

                            document.Add(info);
                            document.Add(empty);
                            document.Add(table);
                            document.Add(empty30);
                            document.Add(table2);
                            document.Add(empty30);
                            document.Add(table3);

                            document.NewPage();
                            document.Add(empty30);
                            document.Add(measure);
                            document.Add(empty);
                            document.Add(table4);

                            document.NewPage();
                            document.Add(empty30);
                            document.Add(chart1);

                            document.Close();
                            CommonClass.isExportPdfClosed = false;
                        }
                        if (MessageBox.Show("저장완료 되었습니다.", "PDF내보내기", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Delay(500);
                            chart.Close();
                            Cursor.Current = Cursors.Default;
                        }
                    }

                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                    System.Diagnostics.Debug.WriteLine(exc);
                }
                finally
                {

                }
            }
        }

        class HeaderFooter : PdfPageEventHelper
        {
            string printTime = "";
            public HeaderFooter(string printTime)
            {
                this.printTime = printTime;
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                try
                {


                    string batangttf = System.IO.Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), @"Fonts\malgun.ttf");
                    BaseFont batangBase = BaseFont.CreateFont(batangttf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    var batang = new iTextSharp.text.Font(batangBase, 12F);
                    var batang_title = new iTextSharp.text.Font(batangBase, 16F, Font.BOLD);


                    //------header

                    PdfPTable tbHeader = new PdfPTable(3);
                    tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                    tbHeader.DefaultCell.Border = 0;
                    tbHeader.AddCell(new Paragraph());

                    PdfPCell cell = new PdfPCell(new Paragraph(" 시 험 결 과 ", batang_title));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;

                    cell.Border = 0;

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("logo3.jpg");

                    Phrase phrase = new Phrase("             " + printTime, batang);

                    logo.SetAbsolutePosition(document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) - 20);
                    logo.ScaleAbsolute(70f, 30f);

                    document.Add(logo);
                    tbHeader.AddCell(cell);
                    tbHeader.AddCell(phrase);





                    tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 10, writer.DirectContent);
                    //--------footer
                    PdfPTable tbFooter = new PdfPTable(3);
                    tbFooter.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                    tbFooter.DefaultCell.Border = 0;
                    tbFooter.AddCell(new Paragraph());

                    cell = new PdfPCell(new Paragraph("" + writer.PageNumber));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Border = 0;
                    tbFooter.AddCell(cell);
                    cell = new PdfPCell(new Paragraph());
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Border = 0;
                    tbFooter.AddCell(cell);
                    tbFooter.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin) - 5, writer.DirectContent);
                }
                catch
                {
                    return;
                }
            }

        }

        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }
    }
}
