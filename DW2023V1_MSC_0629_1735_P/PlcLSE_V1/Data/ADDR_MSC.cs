namespace PlcLSE_V1
{
    /// <summary>
    /// 온/습도 시험기(센서연속 시험) 챔버 IO List
    /// </summary>
    public class ADDR_MSC : ProtocolMapVO
    {
        //Address 구분  Tag Name    Tag Type	"Read/Write"	Data Type	"FEEDBACK상태"	비트타입	Description	unit	Data Range (Min/Max)
        //----------------------------------------------------
        public static string M0000 = "M0000";               //	1	Auto mode   로직 RW  BIT M0100   펄스	1: Auto Mode - 오토모드일 경우만 오토시작 / 정지 가능		0	1
        public static string M0001 = "M0001";               //	2	Manual mode 로직 RW  BIT M0101   펄스	1: Manual mode - 오토 시작일때는 Interlock 필요		0	1
        public static string M0102 = "M0102";               //	3	Auto Start  로직 RW  BIT 사용안함    사용안함	1: Auto Start - 오토시작일 경우 모드 변경 불가		0	1
        public static string M0103 = "M0103";               //	4	Auto Stop   로직 RW  BIT 사용안함    사용안함	1: Auto Stop - 오토정지일 경우 모드 변경 가능		0	1
        public static string M0104 = "M0104";               //	5	Alarm / Emg Reset   Reset RW  BIT 사용안함    펄스 Alarm / Emergency 발생시 Reset 버튼(reset 시 1로 write)      0	1
        public static string M0105 = "M0105";               //	6	Emergency Status    Emg RO  BIT 사용안함    ON/OFF	1: Emergency Status, (Emg 버튼이나 Emg Stop 일 경우)		0	1
        public static string M0106 = "M0106";               //	7	Alarm Status    Alarm RO  BIT 사용안함    ON/OFF	1: Alarm Status(필요없는 경우는 사용안함.) 어드레스는 공통으로 잡아놓음.       0	1
        //----------------------------------------------------
        public static string M0110 = "M0110";       //8		DI-01 ON/OFF 센서  RO BIT DI-01 Status
        public static string M0111 = "M0111";      //9		DI-02 ON/OFF 센서  RO BIT DI-02 Status
        public static string M0112 = "M0112";       //10    	DI-03 ON/OFF 센서  RO BIT DI-03 Status
        public static string M0113 = "M0113";      //11	    DI-04 ON/OFF 센서  RO BIT DI-04 Status 이날로그 아웃풋 2개
        
        //----------------------------------------------------
        public static string M0200 = "M0200";       //14  DO - 01 ON / OFF 센서 RW BIT	1: ON, 0: OFF(DO - 01 출력)
        public static string M0201 = "M0201";       //15  DO - 02 ON / OFF 센서 RW BIT	1: ON, 0: OFF(DO - 02 출력)
        //----------------------------------------------------
        public static string D1000 = "D1000";       //17  AO - 01 출력 센서 RW FLOAT   AO-01 Status
        public static string D1002 = "D1002";       //18  AO-02 출력 센서  RW FLOAT   AO-02 Status
        //----------------------------------------------------
        //검증센서-01 
        public static string D1004 = "D1004";       //25	검증센서-01 Data PV 센서 RO  FLOAT 환산된 실시간 값   mA	4	20																	
        public static string D1006 = "D1006";       //26	검증센서-01 Signal PV   센서 RO  INT 환산되기전 실시간 PLC 값 mA	4	20																	
        public static string D1008 = "D1008";       //27	검증센서-01 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        public static string D1010 = "D1010";       //28	검증센서-01 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        public static string D1012 = "D1012";       //29	검증센서-01 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        public static string D1014 = "D1014";       //30	검증센서-01 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20																	
        public static string D1016 = "D1016";       //31	검증센서-01 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	mA	4	20																	
        public static string D1018 = "D1018";       //32	검증센서-01 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	mA	4	20																	
        public static string D1020 = "D1020";       //33	검증센서-01 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	mA	4	20																	
        public static string D1022 = "D1022";       //34	검증센서-01 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	mA	4	20																	
        public static string D1024 = "D1024";       //35	검증센서-01 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	mA	4	20																	
        public static string D1026 = "D1026";       //36	검증센서-01 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	mA	4	20																	
        public static string D1028 = "D1028";       //37	검증센서-01 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	mA	4	20																	
        public static string D1030 = "D1030";       //38	검증센서-01 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	mA	4	20																	
        public static string D1032 = "D1032";       //39	검증센서-01 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	mA	4	20																	
        public static string D1034 = "D1034";       //40	검증센서-01 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	mA	4	20																	
        public static string D1036 = "D1036";       //41	검증센서-01 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	mA	4	20																	
        public static string D1038 = "D1038";       //42	검증센서-01 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	mA	4	20																	
        public static string D1040 = "D1040";       //43	검증센서-01 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	mA	4	20																	
        public static string D1042 = "D1042";       //44	검증센서-01 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	mA	4	20																	
        public static string D1044 = "D1044";       //45	검증센서-01 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	mA	4	20																	
        public static string D1046 = "D1046";       //46	검증센서-01 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	mA	4	20	
        //----------------------------------------------------
        //검증센서-02
        public static string D1048 = "D1048";       //47	검증센서-02 Data PV	센서	RO	FLOAT	환산된 실시간 값	mA	4	20																	
        public static string D1050 = "D1050";       //48	검증센서-02 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	mA	4	20																	
        public static string D1052 = "D1052";       //49	검증센서-02 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        public static string D1054 = "D1054";       //50	검증센서-02 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        public static string D1056 = "D1056";       //51	검증센서-02 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        public static string D1058 = "D1058";       //52	검증센서-02 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20																	
        public static string D1060 = "D1060";       //53	검증센서-02 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	mA	4	20																	
        public static string D1062 = "D1062";       //54	검증센서-02 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	mA	4	20																	
        public static string D1064 = "D1064";       //55	검증센서-02 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	mA	4	20																	
        public static string D1066 = "D1066";       //56	검증센서-02 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	mA	4	20																	
        public static string D1068 = "D1068";       //57	검증센서-02 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	mA	4	20																	
        public static string D1070 = "D1070";       //58	검증센서-02 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	mA	4	20																	
        public static string D1072 = "D1072";       //59	검증센서-02 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	mA	4	20																	
        public static string D1074 = "D1074";       //60	검증센서-02 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	mA	4	20																	
        public static string D1076 = "D1076";       //61	검증센서-02 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	mA	4	20																	
        public static string D1078 = "D1078";       //62	검증센서-02 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	mA	4	20																	
        public static string D1080 = "D1080";       //63	검증센서-02 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	mA	4	20																	
        public static string D1082 = "D1082";       //64	검증센서-02 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	mA	4	20																	
        public static string D1084 = "D1084";       //65	검증센서-02 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	mA	4	20																	
        public static string D1086 = "D1086";       //66	검증센서-02 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	mA	4	20																	
        public static string D1088 = "D1088";       //67	검증센서-02 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	mA	4	20																	
        public static string D1090 = "D1090";       //68	검증센서-02 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	mA	4	20	

        //----------------------------------------------------
        //검증센서-03
        public static string D1092 = "D1092";   //D1074	69	검증센서-03 Data PV	센서	RO	FLOAT	환산된 실시간 값	mA	4	20																	
        public static string D1094 = "D1094";   //D1076	70	검증센서-03 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	mA	4	20																	
        public static string D1096 = "D1096";   //D1078	71	검증센서-03 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        public static string D1098 = "D1098";   //D1080	72	검증센서-03 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        public static string D1100 = "D1100";   //D1082	73	검증센서-03 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        public static string D1102 = "D1102";   //D1084	74	검증센서-03 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20																	
        //public static string D1074 = "D1074";   //	69	검증센서-03 Data PV	센서	RO	FLOAT	환산된 실시간 값	mA	4	20																	
        //public static string D1076 = "D1076";   //	70	검증센서-03 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	mA	4	20																	
        //public static string D1078 = "D1078";   //	71	검증센서-03 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        //public static string D1080 = "D1080";   //	72	검증센서-03 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        //public static string D1082 = "D1082";   //	73	검증센서-03 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        //public static string D1084 = "D1084";   //	74	검증센서-03 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20	

        public static string D1104 = "D1104";       //75	검증센서-03 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	mA	4	20																	
        public static string D1106 = "D1106";       //76	검증센서-03 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	mA	4	20																	
        public static string D1108 = "D1108";       //77	검증센서-03 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	mA	4	20																	
        public static string D1110 = "D1110";       //78	검증센서-03 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	mA	4	20																	
        public static string D1112 = "D1112";       //79	검증센서-03 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	mA	4	20																	
        public static string D1114 = "D1114";       //80	검증센서-03 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	mA	4	20																	
        public static string D1116 = "D1116";       //81	검증센서-03 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	mA	4	20																	
        public static string D1118 = "D1118";       //82	검증센서-03 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	mA	4	20																	
        public static string D1120 = "D1120";       //83	검증센서-03 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	mA	4	20																	
        public static string D1122 = "D1122";       //84	검증센서-03 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	mA	4	20																	
        public static string D1124 = "D1124";       //85	검증센서-03 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	mA	4	20																	
        public static string D1126 = "D1126";       //86	검증센서-03 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	mA	4	20																	
        public static string D1128 = "D1128";       //87	검증센서-03 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	mA	4	20																	
        public static string D1130 = "D1130";       //88	검증센서-03 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	mA	4	20																	
        public static string D1132 = "D1132";       //89	검증센서-03 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	mA	4	20																	
        public static string D1134 = "D1134";       //90	검증센서-03 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	mA	4	20	

        //----------------------------------------------------
        //검증센서-04
        public static string D1136 = "D1136";   //D1118	91	검증센서-04 Data PV	센서	RO	FLOAT	환산된 실시간 값	mA	4	20																	
        public static string D1138 = "D1138";   //D1120	92	검증센서-04 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	mA	4	20																	
        public static string D1140 = "D1140";   //D1122	93	검증센서-04 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        public static string D1142 = "D1142";   //D1124	94	검증센서-04 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        public static string D1144 = "D1144";   //D1126	95	검증센서-04 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        public static string D1146 = "D1146";   //D1128	96	검증센서-04 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20																	
        //public static string D1118 = "D1118";   //	91	검증센서-04 Data PV	센서	RO	FLOAT	환산된 실시간 값	mA	4	20																	
        //public static string D1120 = "D1120";   //	92	검증센서-04 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	mA	4	20																	
        //public static string D1122 = "D1122";   //	93	검증센서-04 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        //public static string D1124 = "D1124";   //	94	검증센서-04 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        //public static string D1126 = "D1126";   //	95	검증센서-04 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        //public static string D1128 = "D1128";   //	96	검증센서-04 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20	

        //public static string D1148 = "D1148";       //97	검증센서-04 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	mA	4	20																	
        //public static string D1150 = "D1150";       //98	검증센서-04 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	mA	4	20																	
        //public static string D1152 = "D1152";       //99	검증센서-04 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	mA	4	20																	
        //public static string D1154 = "D1154";       //100	검증센서-04 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	mA	4	20																	
        //public static string D1156 = "D1156";       //101	검증센서-04 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	mA	4	20																	
        //public static string D1158 = "D1158";       //102	검증센서-04 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	mA	4	20																	
        //public static string D1160 = "D1160";       //103	검증센서-04 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	mA	4	20																	
        //public static string D1162 = "D1162";       //104	검증센서-04 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	mA	4	20																	
        //public static string D1164 = "D1164";       //105	검증센서-04 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	mA	4	20																	
        //public static string D1166 = "D1166";       //106	검증센서-04 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	mA	4	20																	
        //public static string D1168 = "D1168";       //107	검증센서-04 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	mA	4	20																	
        //public static string D1170 = "D1170";       //108	검증센서-04 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	mA	4	20		
        //public static string D1172 = "D1172";       //109	검증센서-04 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	mA	4	20																	
        //public static string D1174 = "D1174";       //110	검증센서-04 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	mA	4	20																	
        //public static string D1176 = "D1176";       //111	검증센서-04 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	mA	4	20																	
        //public static string D1178 = "D1178";       //112	검증센서-04 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	mA	4	20	

        //----------------------------------------------------					
        //검증센서-05																					
        public static string D1180 = "D1180";       //113	검증센서-05 Data PV	센서	RO	FLOAT	환산된 실시간 값	mA	4	20																	
        public static string D1182 = "D1182";       //114	검증센서-05 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	mA	4	20																	
        public static string D1184 = "D1184";       //115	검증센서-05 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        public static string D1186 = "D1186";       //116	검증센서-05 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        public static string D1188 = "D1188";       //117	검증센서-05 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        public static string D1190 = "D1190";       //118	검증센서-05 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20	
        //public static string D1162 = "D1162";       //113	검증센서-05 Data PV	센서	RO	FLOAT	환산된 실시간 값	mA	4	20																	
        //public static string D1164 = "D1164";       //114	검증센서-05 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	mA	4	20																	
        //public static string D1166 = "D1166";       //115	검증센서-05 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        //public static string D1168 = "D1168";       //116	검증센서-05 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        //public static string D1170 = "D1170";       //117	검증센서-05 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        //public static string D1172 = "D1172";       //118	검증센서-05 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20	

        //public static string D1192 = "D1192";       //119	검증센서-05 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	mA	4	20																	
        //public static string D1194 = "D1194";       //120	검증센서-05 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	mA	4	20																	
        //public static string D1196 = "D1196";       //121	검증센서-05 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	mA	4	20	
        //public static string D1198 = "D1198";       //122	검증센서-05 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	mA	4	20																	
        //public static string D1200 = "D1200";       //123	검증센서-05 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	mA	4	20																	
        //public static string D1202 = "D1202";       //124	검증센서-05 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	mA	4	20																	
        //public static string D1204 = "D1204";       //125	검증센서-05 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	mA	4	20																	
        //public static string D1206 = "D1206";       //126	검증센서-05 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	mA	4	20																	
        //public static string D1208 = "D1208";       //127	검증센서-05 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	mA	4	20																	
        //public static string D1210 = "D1210";       //128	검증센서-05 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	mA	4	20																	
        //public static string D1212 = "D1212";       //129	검증센서-05 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	mA	4	20																	
        //public static string D1214 = "D1214";       //130	검증센서-05 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	mA	4	20																	
        //public static string D1216 = "D1216";       //131	검증센서-05 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	mA	4	20																	
        //public static string D1218 = "D1218";       //132	검증센서-05 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	mA	4	20																	
        //public static string D1220 = "D1220";       //133	검증센서-05 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	mA	4	20																	
        //public static string D1222 = "D1222";       //134	검증센서-05 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	mA	4	20																	

        //----------------------------------------------------					
        //검증센서-06	
        public static string D1224 = "D1224";       //135   검증센서-06 Data PV	센서	RO	FLOAT	환산된 실시간 값	mA	4	20																	
        public static string D1226 = "D1226";       //136   검증센서-06 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	mA	4	20																	
        public static string D1228 = "D1228";       //137   검증센서-06 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	mA	4	20																	
        public static string D1230 = "D1230";       //138   검증센서-06 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	mA	4	20																	
        public static string D1232 = "D1232";       //139   검증센서-06 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	mA	4	20																	
        public static string D1234 = "D1234";       //140   검증센서-06 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	mA	4	20
                                                    //public static string D1236 = "D1236";       //141	검증센서-06 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	mA	4	20																	
                                                    //public static string D1238 = "D1238";       //142	검증센서-06 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	mA	4	20																	
                                                    //public static string D1240 = "D1240";       //143	검증센서-06 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	mA	4	20																	
                                                    //public static string D1242 = "D1242";       //144	검증센서-06 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	mA	4	20																	
                                                    //public static string D1244 = "D1244";       //145	검증센서-06 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	mA	4	20																	
                                                    //public static string D1246 = "D1246";       //146	검증센서-06 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	mA	4	20																	
                                                    //public static string D1248 = "D1248";       //147	검증센서-06 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	mA	4	20																	
                                                    //public static string D1250 = "D1250";       //148	검증센서-06 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	mA	4	20																	
                                                    //public static string D1252 = "D1252";       //149	검증센서-06 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	mA	4	20																	
                                                    //public static string D1254 = "D1254";       //150	검증센서-06 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	mA	4	20																	
                                                    //public static string D1256 = "D1256";       //151	검증센서-06 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	mA	4	20																	
                                                    //public static string D1258 = "D1258";       //152	검증센서-06 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	mA	4	20																	
                                                    //public static string D1260 = "D1260";       //153	검증센서-06 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	mA	4	20																	
                                                    //public static string D1262 = "D1262";       //154	검증센서-06 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	mA	4	20																	
                                                    //public static string D1264 = "D1264";       //155	검증센서-06 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	mA	4	20																	
                                                    //public static string D1266 = "D1266";       //156	검증센서-06 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	mA	4	20																	

        //----------------------------------------------------					
        //검증센서-07	
        public static string D1268 = "D1268";   //D1250	157	검증센서-07 Data PV	센서	RO	FLOAT	환산된 실시간 값	V	0	10																	
        public static string D1270 = "D1270";   //D1252	158	검증센서-07 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	V	0	10																	
        public static string D1272 = "D1272";   //D1254	159	검증센서-07 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	V	0	10																	
        public static string D1274 = "D1274";   //D1256	160	검증센서-07 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	V	0	10																	
        public static string D1276 = "D1276";   //D1258	161	검증센서-07 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	V	0	10																	
        public static string D1278 = "D1278";   //D1260	162	검증센서-07 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	V	0	10																	
        //public static string D1280 = "D1280";   //D1262	163	검증센서-07 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	V	0	10																	
        //public static string D1282 = "D1282";   //D1264	164	검증센서-07 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	V	0	10																	
        //public static string D1284 = "D1284";   //D1266	165	검증센서-07 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	V	0	10																	
        //public static string D1286 = "D1286";   //D1268	166	검증센서-07 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	V	0	10																	
        //public static string D1288 = "D1288";   //D1270	167	검증센서-07 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	V	0	10																	
        //public static string D1290 = "D1290";   //D1272	168	검증센서-07 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	V	0	10																	
        //public static string D1292 = "D1292";   //D1274	169	검증센서-07 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	V	0	10																	
        //public static string D1294 = "D1294";   //D1276	170	검증센서-07 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	V	0	10																	
        //public static string D1296 = "D1296";   //D1278	171	검증센서-07 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	V	0	10																	
        //public static string D1298 = "D1298";   //D1280	172	검증센서-07 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	V	0	10																	
        //public static string D1300 = "D1300";   //D1282	173	검증센서-07 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	V	0	10																	
        //public static string D1302 = "D1302";   //D1284	174	검증센서-07 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	V	0	10																	
        //public static string D1304 = "D1304";   //D1286	175	검증센서-07 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	V	0	10																	
        //public static string D1306 = "D1306";   //D1288	176	검증센서-07 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	V	0	10																	
        //public static string D1308 = "D1308";   //D1290	177	검증센서-07 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	V	0	10																	
        //public static string D1310 = "D1310";   //D1292	178	검증센서-07 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	V	0	10																	
        //public static string D1250 = "D1250";   //D1250	157	검증센서-07 Data PV	센서	RO	FLOAT	환산된 실시간 값	V	0	10																	
        //public static string D1252 = "D1252";   //D1252	158	검증센서-07 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	V	0	10																	
        //public static string D1254 = "D1254";   //D1254	159	검증센서-07 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	V	0	10																	
        //public static string D1256 = "D1256";   //D1256	160	검증센서-07 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	V	0	10																	
        //public static string D1258 = "D1258";   //D1258	161	검증센서-07 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	V	0	10																	
        //public static string D1260 = "D1260";   //D1260	162	검증센서-07 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	V	0	10																	
        //public static string D1262 = "D1262";   //D1262	163	검증센서-07 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	V	0	10																	
        //public static string D1264 = "D1264";   //D1264	164	검증센서-07 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	V	0	10																	
        //public static string D1266 = "D1266";   //D1266	165	검증센서-07 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	V	0	10																	
        //public static string D1268 = "D1268";   //D1268	166	검증센서-07 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	V	0	10																	
        //public static string D1270 = "D1270";   //D1270	167	검증센서-07 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	V	0	10																	
        //public static string D1272 = "D1272";   //D1272	168	검증센서-07 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	V	0	10																	
        //public static string D1274 = "D1274";   //D1274	169	검증센서-07 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	V	0	10																	
        //public static string D1276 = "D1276";   //D1276	170	검증센서-07 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	V	0	10																	
        //public static string D1278 = "D1278";   //D1278	171	검증센서-07 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	V	0	10																	
        //public static string D1280 = "D1280";   //D1280	172	검증센서-07 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	V	0	10																	
        //public static string D1282 = "D1282";   //D1282	173	검증센서-07 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	V	0	10																	
        //public static string D1284 = "D1284";   //D1284	174	검증센서-07 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	V	0	10																	
        //public static string D1286 = "D1286";   //D1286	175	검증센서-07 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	V	0	10																	
        //public static string D1288 = "D1288";   //D1288	176	검증센서-07 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	V	0	10																	
        //public static string D1290 = "D1290";   //D1290	177	검증센서-07 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	V	0	10																	
        //public static string D1292 = "D1292";   //D1292	178	검증센서-07 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	V	0	10		

        //----------------------------------------------------					
        //검증센서-08	
        public static string D1312 = "D1312";       //179	검증센서-08 Data PV	센서	RO	FLOAT	환산된 실시간 값	V	0	10																	
        public static string D1314 = "D1314";       //180	검증센서-08 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	V	0	10																	
        public static string D1316 = "D1316";       //181	검증센서-08 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	V	0	10																	
        public static string D1318 = "D1318";       //182	검증센서-08 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	V	0	10																	
        public static string D1320 = "D1320";       //183	검증센서-08 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	V	0	10																	
        public static string D1322 = "D1322";       //184	검증센서-08 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	V	0	10																	
        //public static string D1324 = "D1324";       //185	검증센서-08 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	V	0	10																	
        //public static string D1326 = "D1326";       //186	검증센서-08 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	V	0	10																	
        //public static string D1328 = "D1328";       //187	검증센서-08 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	V	0	10																	
        //public static string D1330 = "D1330";       //188	검증센서-08 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	V	0	10																	
        //public static string D1332 = "D1332";       //189	검증센서-08 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	V	0	10																	
        //public static string D1334 = "D1334";       //190	검증센서-08 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	V	0	10																	
        //public static string D1336 = "D1336";       //191	검증센서-08 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	V	0	10																	
        //public static string D1338 = "D1338";       //192	검증센서-08 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	V	0	10																	
        //public static string D1340 = "D1340";       //193	검증센서-08 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	V	0	10																	
        //public static string D1342 = "D1342";       //194	검증센서-08 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	V	0	10																	
        //public static string D1344 = "D1344";       //195	검증센서-08 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	V	0	10																	
        //public static string D1346 = "D1346";       //196	검증센서-08 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	V	0	10																	
        //public static string D1348 = "D1348";       //197	검증센서-08 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	V	0	10																	
        //public static string D1350 = "D1350";       //198	검증센서-08 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	V	0	10																	
        //public static string D1352 = "D1352";       //199	검증센서-08 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	V	0	10																	
        //public static string D1354 = "D1354";       //200	검증센서-08 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	V	0	10																	

        //----------------------------------------------------					
        //검증센서-09	
        public static string D1356 = "D1356";       //201	검증센서-09 Data PV	센서	RO	FLOAT	환산된 실시간 값	V	0	10																	
        public static string D1358 = "D1358";       //202	검증센서-09 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	V	0	10																	
        public static string D1360 = "D1360";       //203	검증센서-09 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	V	0	10																	
        public static string D1362 = "D1362";       //204	검증센서-09 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	V	0	10																	
        public static string D1364 = "D1364";       //205	검증센서-09 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	V	0	10																	
        public static string D1366 = "D1366";       //206	검증센서-09 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	V	0	10																	

        //public static string D1368 = "D1368";       //207	검증센서-09 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	V	0	10																	
        //public static string D1370 = "D1370";       //208	검증센서-09 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	V	0	10																	
        //public static string D1372 = "D1372";       //209	검증센서-09 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	V	0	10																	
        //public static string D1374 = "D1374";       //210	검증센서-09 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	V	0	10																	
        //public static string D1376 = "D1376";       //211	검증센서-09 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	V	0	10																	
        //public static string D1378 = "D1378";       //212	검증센서-09 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	V	0	10																	
        //public static string D1380 = "D1380";       //213	검증센서-09 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	V	0	10																	
        //public static string D1382 = "D1382";       //214	검증센서-09 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	V	0	10																	
        //public static string D1384 = "D1384";       //215	검증센서-09 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	V	0	10																	
        //public static string D1386 = "D1386";       //216	검증센서-09 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	V	0	10																	
        //public static string D1388 = "D1388";       //217	검증센서-09 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	V	0	10																	
        //public static string D1390 = "D1390";       //218	검증센서-09 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	V	0	10																	
        //public static string D1392 = "D1392";       //219	검증센서-09 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	V	0	10																	
        //public static string D1394 = "D1394";       //220	검증센서-09 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	V	0	10																	
        //public static string D1396 = "D1396";       //221	검증센서-09 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	V	0	10																	
        //public static string D1398 = "D1398"; //222 검증센서 - 09 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	V	0	10																	

        //----------------------------------------------------					
        //검증센서-10
        public static string D1400 = "D1400";       //223	검증센서-10 Data PV	센서	RO	FLOAT	환산된 실시간 값	V	0	10																	
        public static string D1402 = "D1402";       //224	검증센서-10 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	V	0	10																	
        public static string D1404 = "D1404";       //225	검증센서-10 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	V	0	10																	
        public static string D1406 = "D1406";       //226	검증센서-10 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	V	0	10																	
        public static string D1408 = "D1408";       //227	검증센서-10 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	V	0	10																	
        public static string D1410 = "D1410";       //228	검증센서-10 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	V	0	10																	
        //public static string D1412 = "D1412";       //229	검증센서-10 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	V	0	10																	
        //public static string D1414 = "D1414";       //230	검증센서-10 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	V	0	10																	
        //public static string D1416 = "D1416";       //231	검증센서-10 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	V	0	10																	
        //public static string D1418 = "D1418";       //232	검증센서-10 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	V	0	10																	
        //public static string D1420 = "D1420";       //233	검증센서-10 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	V	0	10																	
        //public static string D1422 = "D1422";       //234	검증센서-10 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	V	0	10																	
        //public static string D1424 = "D1424";       //235	검증센서-10 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	V	0	10																	
        //public static string D1426 = "D1426";       //236	검증센서-10 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	V	0	10																	
        //public static string D1428 = "D1428";       //237	검증센서-10 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	V	0	10																	
        //public static string D1430 = "D1430";       //238	검증센서-10 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	V	0	10																	
        //public static string D1432 = "D1432";       //239	검증센서-10 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	V	0	10																	
        //public static string D1434 = "D1434";       //240	검증센서-10 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	V	0	10																	
        //public static string D1436 = "D1436";       //241	검증센서-10 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	V	0	10																	
        //public static string D1438 = "D1438";       //242	검증센서-10 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	V	0	10																	
        //public static string D1440 = "D1440";       //243	검증센서-10 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	V	0	10																	
        //public static string D1442 = "D1442";       //244	검증센서-10 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	V	0	10																	

        //----------------------------------------------------					
        //검증센서-11
        public static string D1444 = "D1444";       //245	검증센서-11 Data PV	센서	RO	FLOAT	환산된 실시간 값	V	0	10																	
        public static string D1446 = "D1446";       //246	검증센서-11 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	V	0	10																	
        public static string D1448 = "D1448";       //247	검증센서-11 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	V	0	10																	
        public static string D1450 = "D1450";       //248	검증센서-11 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	V	0	10																	
        public static string D1452 = "D1452";       //249	검증센서-11 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	V	0	10																	
        public static string D1454 = "D1454";       //250	검증센서-11 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	V	0	10		
        //public static string D1456 = "D1456";       //251	검증센서-11 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	V	0	10																	
        //public static string D1458 = "D1458";       //252	검증센서-11 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	V	0	10																	
        //public static string D1460 = "D1460";       //253	검증센서-11 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	V	0	10																	
        //public static string D1462 = "D1462";       //254	검증센서-11 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	V	0	10																	
        //public static string D1464 = "D1464";       //255	검증센서-11 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	V	0	10																	
        //public static string D1466 = "D1466";       //256	검증센서-11 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	V	0	10																	
        //public static string D1468 = "D1468";       //257	검증센서-11 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	V	0	10																	
        //public static string D1470 = "D1470";       //258	검증센서-11 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	V	0	10																	
        //public static string D1472 = "D1472";       //259	검증센서-11 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	V	0	10																	
        //public static string D1474 = "D1474";       //260	검증센서-11 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	V	0	10																	
        //public static string D1476 = "D1476";       //261	검증센서-11 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	V	0	10																	
        //public static string D1478 = "D1478";       //262	검증센서-11 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	V	0	10																	
        //public static string D1480 = "D1480";       //263	검증센서-11 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	V	0	10																	
        //public static string D1482 = "D1482";       //264	검증센서-11 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	V	0	10																	
        //public static string D1484 = "D1484";       //265	검증센서-11 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	V	0	10																	
        //public static string D1486 = "D1486";       //266	검증센서-11 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	V	0	10																	


        //----------------------------------------------------					
        //검증센서-12
        public static string D1488 = "D1488";       //267	검증센서-12 Data PV	센서	RO	FLOAT	환산된 실시간 값	V	0	10																	
        public static string D1490 = "D1490";       //268	검증센서-12 Signal PV	센서	RO	INT	환산되기전 실시간 PLC 값	V	0	10																	
        public static string D1492 = "D1492";       //269	검증센서-12 PLC Min Set #1	PLC 로직	RW	FLOAT	PLC 원천 min Data #1 구간	V	0	10																	
        public static string D1494 = "D1494";       //270	검증센서-12 PLC Max Set #1	PLC 로직	RW	FLOAT	PLC 원천 max Data #1 구간	V	0	10																	
        public static string D1496 = "D1496";       //271	검증센서-12 Data Min Set #1	PLC 로직	RW	FLOAT	환산 min Data #1 구간	V	0	10																	
        public static string D1498 = "D1498";       //272	검증센서-12 Data Max Set #1	PLC 로직	RW	FLOAT	환산 max Data #1 구간	V	0	10																	
        //public static string D1500 = "D1500";       //273	검증센서-12 PLC Min Set #2	PLC 로직	RW	FLOAT	PLC 원천 min Data #2 구간	V	0	10																	
        //public static string D1502 = "D1502";       //274	검증센서-12 PLC Max Set #2	PLC 로직	RW	FLOAT	PLC 원천 max Data #2 구간	V	0	10																	
        //public static string D1504 = "D1504";       //275	검증센서-12 Data Min Set #2	PLC 로직	RW	FLOAT	환산 min Data #2 구간	V	0	10																	
        //public static string D1506 = "D1506";       //276	검증센서-12 Data Max Set #2	PLC 로직	RW	FLOAT	환산 max Data #2 구간	V	0	10																	
        //public static string D1508 = "D1508";       //277	검증센서-12 PLC Min Set #3	PLC 로직	RW	FLOAT	PLC 원천 min Data #3 구간	V	0	10																	
        //public static string D1510 = "D1510";       //278	검증센서-12 PLC Max Set #3	PLC 로직	RW	FLOAT	PLC 원천 max Data #3 구간	V	0	10																	
        //public static string D1512 = "D1512";       //279	검증센서-12 Data Min Set #3	PLC 로직	RW	FLOAT	환산 min Data #3 구간	V	0	10																	
        //public static string D1514 = "D1514";       //280	검증센서-12 Data Max Set #3	PLC 로직	RW	FLOAT	환산 max Data #3 구간	V	0	10																	
        //public static string D1516 = "D1516";       //281	검증센서-12 PLC Min Set #4	PLC 로직	RW	FLOAT	PLC 원천 min Data #4 구간	V	0	10																	
        //public static string D1518 = "D1518";       //282	검증센서-12 PLC Max Set #4	PLC 로직	RW	FLOAT	PLC 원천 max Data #4 구간	V	0	10																	
        //public static string D1520 = "D1520";       //283	검증센서-12 Data Min Set #4	PLC 로직	RW	FLOAT	환산 min Data #4 구간	V	0	10																	
        //public static string D1522 = "D1522";       //284	검증센서-12 Data Max Set #4	PLC 로직	RW	FLOAT	환산 max Data #4 구간	V	0	10																	
        //public static string D1524 = "D1524";       //285	검증센서-12 PLC Min Set #5	PLC 로직	RW	FLOAT	PLC 원천 min Data #5 구간	V	0	10																	
        //public static string D1526 = "D1526";       //286	검증센서-12 PLC Max Set #5	PLC 로직	RW	FLOAT	PLC 원천 max Data #5 구간	V	0	10																	
        //public static string D1528 = "D1528";       //287	검증센서-12 Data Min Set #5	PLC 로직	RW	FLOAT	환산 min Data #5 구간	V	0	10																	
        //public static string D1530 = "D1530";       //288	검증센서-12 Data Max Set #5	PLC 로직	RW	FLOAT	환산 max Data #5 구간	V	0	10																	

    }
}




































































































































































































































































































































































































































































































































































































































































































