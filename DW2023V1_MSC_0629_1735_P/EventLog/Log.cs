using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EventLog
{
    public class MeasureWriteLog
    {
        /****************************info*******************************/
      
        public string MeasureProgramStartEventLog = "[측정프로그램] 측정프로그램 시작";
        public string MeasureProgramEndEventLog = "[측정프로그램] 측정프로그램 종료";
        public string DashBoardMenuClickEventLog = "[측정프로그램] 대시보드 메뉴 선택";
        public string RecipeManageMenuClickEventLog = "[측정프로그램] 레시피 관리 메뉴 선택";
        public string MeasureManageMenuClickEventLog = "[측정프로그램] 시험측정 메뉴 선택";
        public string RequesterSampleManageMenuClickEventLog = "[측정프로그램] 의뢰자샘플 관리 메뉴 선택";
        public string UserManageMenuClickEventLog = "[측정프로그램] 사용자 관리 메뉴 선택";
        public string RequesterManageMenuClickEventLog = "[측정프로그램] 의뢰자 관리 메뉴 선택";
        public string PatternMenuClickEventLog = "[측정프로그램] 패턴 관리 메뉴 선택";
        public string CalibManageMenuClickEventLog = "[측정프로그램] 캘리브레이션 관리 메뉴 선택";
        public string HMIManageMenuClickEventLog = "[측정프로그램] HMI 관리 메뉴 선택";
        public string PLCIManageMenuClickEventLog = "[측정프로그램] PLC컨트롤러 관리 메뉴 선택";
        public string DBMSManageMenuClickEventLog = "[측정프로그램] DBMS 연동관리 메뉴 선택";

        //측정관리
        public string AutoModeClickEventLog = "[측정 관리] 자동모드 선택";
        public string ManualModeClickEventLog = "[측정 관리] 수동모드 선택";
        public string RecipeChooseEventLog = "[측정 관리] 레시피 선택";
        public string SettingModeClickEventLog = "[측정 관리] 정치모드 선택";
        public string PatternModeClickEventLog = "[측정 관리] 패턴모드 선택";
        public string ChamberStertClickEventLog = "[측정 관리] 챔버가동 선택";
        public string ChamberStopClickEventLog = "[측정 관리] 챔버중지 선택";
        public string MeasureStartClickEventLog = "[측정 관리] 측정 시작";
        public string MeasureReStartClickEventLog = "[측정 관리] 재측정 시작";
        public string MeasureEndEventLog = "[측정 관리] 측정 완료";
        public string TestResultClickEventLog = "[측정 관리] 테스트 결과보기 버튼 클릭";
        public string MeasureStopClickEventLog = "[측정 관리] 측정 중지";
        public string RecipeSearchListClickEventLog = "[측정 관리] 레시피 검색";
        public string RecipeChooseClickEventLog = "[측정 관리] 레시피 선택 버튼 클릭";


        //의뢰자관리
        public string RequesterSearchClickEventLog = "[의뢰자 관리] 의뢰자 검색";
        public string RequesterManageUpdateEventLog = "[의뢰자 관리] 의뢰자 수정";
        public string RequesterDeleteEventLog = "[의뢰자 관리] 의뢰자 삭제";
        public string RequesterManageNewRegisterEventLog = "[의뢰자 관리] 의뢰자 신규등록";

        //의뢰자 샘플관리
        public string RequesterSampleSearchClickEventLog = "[의뢰자샘플 관리] 의뢰자샘플 검색";
        public string RequesterSampleManageUpdateEventLog = "[의뢰자샘플 관리] 의뢰자샘플 수정";
        public string RequesterSampleDeleteEventLog = "[의뢰자샘플 관리] 의뢰자샘플 삭제";
        public string RequesterSampleManageNewRegisterEventLog = "[의뢰자샘플 관리] 의뢰자샘플 신규등록";

        //레시피 관리
        public string RecipeSearchClickEventLog = "[레시피 관리] 레시피 검색";
        public string RecipeUpdateEventLog = "[레시피 관리] 레시피 수정";
        public string RecipeDeleteEventLog = "[레시피 관리] 레시피 삭제";
        public string RecipeNewRegisterEventLog = "[레시피 관리] 레시피 신규등록";

        //사용자 관리
        public string UserSearchClickEventLog = "[사용자 관리] 사용자 검색";
        public string UserUpdateEventLog = "[사용자 관리] 사용자 수정";
        public string UserDeleteEventLog = "[사용자 관리] 사용자 삭제";
        public string UserNewRegisterEventLog = "[사용자 관리] 사용자 신규등록";
        public string UserPasswordResetClickEventLog = "[사용자 관리] 사용자 비밀번호 초기화 버튼 클릭";
        public string UserPasswordResetEventLog = "[사용자 관리] 사용자 비밀번호 초기화 ";

        //패턴 관리
        public string PatternSearchClickEventLog = "[패턴 관리] 패턴 검색";
        public string PatternDeleteEventLog = "[패턴 관리] 패턴 삭제";
        public string ChosenPatternReadEventLog = "[패턴 관리] 지정 패턴 읽기";
        public string ChosenPatternRegisterEventLog = "[패턴 관리] 지정 패턴 등록";
        public string AllPatternRnREventLog = "[패턴 관리] 일괄 패턴 읽기 및 등록";

        //PLC 관리
        public string PLCSearchClickEventLog = "[PLC 관리] PLC 검색";
        public string PLCUpdateEventLog = "[PLC 관리] PLC 수정";
        public string PLCDeleteEventLog = "[PLC 관리] PLC 삭제";
        public string PLCNewRegisterEventLog = "[PLC 관리] PLC 신규등록";

        //컨트롤러관리
        public string HMIConnectEventLog = "[HMI 관리] 연결상태 확인";

        public string PLCConnectEventLog = "[PLC 관리] 연결상태 확인";

        public string DBMSConnectEventLog = "[DBMS 연결관리] DBMS 연결상태 확인";
        public string PortConnectEventLog = "[DBMS 연결관리] Port 연결상태 확인";


        /****************************warn********************************/

        public string RecipeRegisterItemBlank = "[레시피 신규 등록] 항목이 채워지지 않음";

        public string MeasureRecipeNotSelected = "[측정관리] 측정 시작 - 선택된 레시피 없음";
        public string MeasureNotStared = "[측정관리] 측정 중지 - 측정이 시작되지 않음";

        /****************************error*******************************/

        public string DashBoardDayAnalyzeInfoLoadError = "[대시보드]일간 측정 통계 로드 에러";
        public string DashBoardDayAnalyzeRowChooseLoadError = "[대시보드] 일간 측정 통계 선택 로드 에러";

        public string RecipeRegistInsertError = "[레시피 신규 등록] 레시피 신규 등록 에러";

        public string MeasureRecipeInfoLoadError = "[측정관리] 레시피 정보 로드 에러";
        public string MeasureFlagError = "[측정관리] PLC 플래그 에러";
        public string MeasureDataInsertError = "[측정관리] 측정 데이터 삽입 에러";
        public string MeasureResultDataInsertError = "[측정관리] 측정 데이터 결과 삽입 에러";
        public string MeasureStopDeleteError = "[측정관리] 측정 데이터 삭제 에러";



        public string RequesterListShowLoadError = "[의뢰자 관리] 의뢰자 리스트 로드 에러";
        public string RequesterDetailLoadError = "[의뢰자 관리] 의뢰자 상세내용 로드 에러";
        public string RequesterDeleteError = "[의뢰자 관리] 의뢰자 삭제 에러";
        public string RequesterUpdateError = "[의뢰자 관리] 의뢰자 수정 에러";
        public string RequesterRegisterError = "[의뢰자 관리] 의뢰자 신규등록 에러";
        public string RequesterSearchLoadError = "[의뢰자 관리] 의뢰자 검색 내용 로드 에러";

        public string RequesterSmapleListShowLoadError = "[의뢰자샘플 관리] 의뢰자샘플 리스트 로드 에러";
        public string RequesterSmapleDetailLoadError = "[의뢰자샘플 관리] 의뢰자샘플 상세내용 로드 에러";
        public string RequesterSmapleDeleteError = "[의뢰자샘플 관리] 의뢰자샘플 삭제 에러";
        public string RequesterSmapleUpdateError = "[의뢰자샘플 관리] 의뢰자샘플 수정 에러";
        public string RequesterSmapleRegisterError = "[의뢰자샘플 관리] 의뢰자샘플 신규등록 에러";
        public string RequesterSmapleSearchLoadError = "[의뢰자샘플 관리] 의뢰자샘플 검색 내용 로드 에러";

        public string RecipeListShowLoadError = "[레시피 관리] 레시피 리스트 로드 에러";
        public string RecipeDetailLoadError = "[레시피 관리] 레시피 상세내용 로드 에러";
        public string RecipeDeleteError = "[레시피 관리] 레시피 삭제 에러";
        public string RecipeUpdateError = "[레시피 관리] 레시피 수정 에러";
        public string RecipeRegisterError = "[레시피 관리] 레시피 신규등록 에러";
        public string RecipeSearchLoadError = "[레시피 관리] 레시피 검색 내용 로드 에러";

        public string UserListShowLoadError = "[사용자 관리] 사용자 리스트 로드 에러";
        public string UserDetailLoadError = "[사용자 관리] 사용자 상세내용 로드 에러";
        public string UserDeleteError = "[사용자 관리] 사용자 삭제 에러";
        public string UserUpdateError = "[사용자 관리] 사용자 수정 에러";
        public string UserRegisterError = "[사용자 관리] 사용자 신규등록 에러";
        public string UserSearchLoadError = "[사용자 관리] 사용자 검색 내용 로드 에러";



        //패턴 관리
        public string PatternListShowLoadError = "[패턴 관리] 패턴 리스트 로드 에러";
        public string PatternDeleteError = "[패턴 관리] 패턴 삭제 에러";
        public string ChosenPatternReadError = "[패턴 관리] 지정 패턴 읽기 에러";
        public string ChosenPatternRegisterError = "[패턴 관리] 지정 패턴 등록 에러";
        public string AllPatternRnRError = "[패턴 관리] 일괄 패턴 읽기 및 등록 에러";


        //PLC 관리
        public string PLCListShowLoadError = "[PLC 관리] PLC 리스트 로드 에러";
        public string PLCDetailLoadError = "[PLC 관리] PLC 상세내용 로드 에러";
        public string PLCDeleteError = "[PLC 관리] PLC 삭제 에러";
        public string PLCUpdateError = "[PLC 관리] PLC 수정 에러";
        public string PLCRegisterError = "[PLC 관리] PLC 신규등록 에러";
        public string PLCSearchLoadError = "[PLC 관리] PLC 검색 내용 로드 에러";
    }

    public class LoginWriteLog
    {
        /****************************info*******************************/

        public string LoginOk = "[로그인] 로그인 되었습니다.";
        public string LogoutOk = "[로그아웃] 로그아웃 되었습니다.";

        /****************************error*******************************/
        public string LoginError = "[로그인] 로그인 에러.";

    }

    public class AnalyzeWriteLog
    {
        /****************************info*******************************/
        public string AnalysisProgramStartEventLog = "[분석프로그램] 분석프로그램 시작";
        public string AnalysisEndEventLog = "[분석프로그램] 분석프로그램 종료";

        public string DashBoardMenuClickEventLog = "[분석프로그램] 대시보드 메뉴 선택";
        public string TestListManageClickEventLog = "[분석프로그램] 측정이력조회 메뉴 선택";
        public string AlarmListManageClickEventLog = "[분석프로그램] 알람이력조회 메뉴 선택";

        public string MeasureListSearchEventLog = "[측정이력조회] 측정이력 검색";
        public string ShowMeasureDetailEventLog = "[측정이력조회] 측정이력 상세보기";
        public string TestResultEventLog = "[측정이력조회] 테스트결과 레포트";
        public string MeasureListExportCSVEventLog = "[측정이력조회] CSV내보내기";


        public string AlarmSearchEventLog = "[알람이력조회] 알람이력 검색";
        public string AlarmSendCSVEventLog = "[알람이력조회] CSV내보내기";

        /****************************warn*******************************/


        /****************************error*******************************/
        public string DashBoardDayAnalyzeInfoLoadError = "[대시보드] 통계 데이터 로드 에러";

        public string MeasureListSearchError = "[측정이력조회] 측정이력 검색 에러";
        public string ShowMeasureDetailError = "[측정이력조회] 측정이력 상세보기 에러";
        public string TestResultError = "[측정이력조회] 테스트결과 레포트 에러";
        public string MeasureListExportCSVError = "[측정이력조회] CSV내보내기 에러";

        public string AlarmSearchError = "[알람이력조회] 측정이력 검색 에러";
        public string AlarmListExportCSVError = "[알람이력조회] CSV내보내기 에러";
    }
}
