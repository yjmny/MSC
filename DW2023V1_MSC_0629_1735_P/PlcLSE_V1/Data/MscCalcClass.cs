namespace PlcLSE_V1.Data
{
    internal class MscCalcClass
    {

        public MscCalcClass() { }

        public void CalculationX(double dx1, double dy1, double dx2, double dy2, out double dResultX, double dTempY)
        {
            //double y = ax+b

            double dy = dy2 - dy1;
            double dx= dx2 - dx1;
            double a = dy / dx;
            double b = dy1 - (a * dx1);

            //x = (y-b)/a
            dResultX = (dTempY - b) / a;

            //System.Diagnostics.Debug.WriteLine("a_{0}, b_{1}, out_x{2}, y{3}",a,b, dResultX, dTempY);
        }
        public void CalculationY(double dx1, double dy1, double dx2, double dy2, out double dResultY, double dTempX)
        {
            //double y = ax+b

            double dy = dy2 - dy1;
            double dx = dx2 - dx1;
            double a = dy / dx;
            double b = dy1 - (a * dx1);

            //x = (y-b)/a
            dResultY = (dTempX - b) / a;

            //System.Diagnostics.Debug.WriteLine("a_{0}, b_{1}, x{2}, out_y{3}", a, b, dTempX, dResultY);
        }
    }
}
