namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module Icon =
        
    [<RequireQualifiedAccess>]
    type AntIcon =
        | Spin of bool
        | Rotate of float
        | TwoToneColor of string
        static member Custom (key: string, value: obj): AntIcon = unbox(key, value)
        static member Style (css: Props.CSSProp list): AntIcon = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antIconAccountBookFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AccountBookFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAccountBookOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AccountBookOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAccountBookTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AccountBookTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAimOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AimOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlertFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlertFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlertOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlertOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlertTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlertTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlibabaOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlibabaOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlignCenterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlignCenterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlignLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlignLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlignRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlignRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlipayCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlipayCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlipayCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlipayCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlipayOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlipayOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAlipaySquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AlipaySquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAliwangwangFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AliwangwangFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAliwangwangOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AliwangwangOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAliyunOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AliyunOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAmazonCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AmazonCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAmazonOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AmazonOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAmazonSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AmazonSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAndroidFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AndroidFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAndroidOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AndroidOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAntCloudOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AntCloudOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAntDesignOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AntDesignOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconApartmentOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ApartmentOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconApiFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ApiFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconApiOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ApiOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconApiTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ApiTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAppleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AppleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAppleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AppleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAppstoreAddOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AppstoreAddOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAppstoreFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AppstoreFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAppstoreOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AppstoreOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAppstoreTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AppstoreTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAreaChartOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AreaChartOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconArrowDownOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ArrowDownOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconArrowLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ArrowLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconArrowRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ArrowRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconArrowUpOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ArrowUpOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconArrowsAltOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ArrowsAltOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAudioFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AudioFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAudioMutedOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AudioMutedOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAudioOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AudioOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAudioTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AudioTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconAuditOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "AuditOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBackwardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BackwardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBackwardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BackwardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBankFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BankFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBankOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BankOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBankTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BankTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBarChartOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BarChartOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBarcodeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BarcodeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBarsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BarsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBehanceCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BehanceCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBehanceOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BehanceOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBehanceSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BehanceSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBehanceSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BehanceSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBellFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BellFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBellOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BellOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBellTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BellTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBgColorsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BgColorsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBlockOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BlockOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBoldOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BoldOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBookFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BookFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBookOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BookOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBookTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BookTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderBottomOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderBottomOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderHorizontalOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderHorizontalOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderInnerOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderInnerOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderOuterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderOuterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderTopOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderTopOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderVerticleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderVerticleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBorderlessTableOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BorderlessTableOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBoxPlotFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BoxPlotFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBoxPlotOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BoxPlotOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBoxPlotTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BoxPlotTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBranchesOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BranchesOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBugFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BugFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBugOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BugOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBugTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BugTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBuildFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BuildFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBuildOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BuildOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBuildTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BuildTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBulbFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BulbFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBulbOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BulbOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconBulbTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "BulbTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCalculatorFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CalculatorFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCalculatorOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CalculatorOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCalculatorTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CalculatorTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCalendarFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CalendarFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCalendarOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CalendarOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCalendarTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CalendarTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCameraFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CameraFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCameraOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CameraOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCameraTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CameraTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCarFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CarFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCarOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CarOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCarTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CarTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCaretDownFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CaretDownFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCaretDownOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CaretDownOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCaretLeftFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CaretLeftFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCaretLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CaretLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCaretRightFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CaretRightFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCaretRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CaretRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCaretUpFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CaretUpFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCaretUpOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CaretUpOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCarryOutFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CarryOutFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCarryOutOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CarryOutOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCarryOutTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CarryOutTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCheckCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CheckCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCheckCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CheckCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCheckCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CheckCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCheckOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CheckOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCheckSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CheckSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCheckSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CheckSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCheckSquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CheckSquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconChromeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ChromeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconChromeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ChromeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCiCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CiCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCiCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CiCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCiCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CiCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCiOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CiOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCiTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CiTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconClearOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ClearOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconClockCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ClockCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconClockCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ClockCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconClockCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ClockCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloseCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloseCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloseCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloseCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloseCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloseCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloseOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloseOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloseSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloseSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloseSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloseSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloseSquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloseSquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloudDownloadOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloudDownloadOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloudFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloudFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloudOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloudOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloudServerOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloudServerOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloudSyncOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloudSyncOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloudTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloudTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCloudUploadOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CloudUploadOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconClusterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ClusterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodeSandboxCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodeSandboxCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodeSandboxOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodeSandboxOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodeSandboxSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodeSandboxSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodeTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodeTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodepenCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodepenCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodepenCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodepenCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodepenOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodepenOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCodepenSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CodepenSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCoffeeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CoffeeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconColumnHeightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ColumnHeightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconColumnWidthOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ColumnWidthOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCommentOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CommentOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCompassFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CompassFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCompassOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CompassOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCompassTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CompassTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCompressOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CompressOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconConsoleSqlOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ConsoleSqlOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconContactsFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ContactsFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconContactsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ContactsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconContactsTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ContactsTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconContainerFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ContainerFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconContainerOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ContainerOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconContainerTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ContainerTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconControlFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ControlFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconControlOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ControlOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconControlTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ControlTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCopyFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CopyFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCopyOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CopyOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCopyTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CopyTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCopyrightCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CopyrightCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCopyrightCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CopyrightCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCopyrightCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CopyrightCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCopyrightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CopyrightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCopyrightTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CopyrightTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCreditCardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CreditCardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCreditCardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CreditCardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCreditCardTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CreditCardTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCrownFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CrownFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCrownOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CrownOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCrownTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CrownTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCustomerServiceFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CustomerServiceFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCustomerServiceOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CustomerServiceOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconCustomerServiceTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "CustomerServiceTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDashOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DashOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDashboardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DashboardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDashboardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DashboardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDashboardTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DashboardTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDatabaseFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DatabaseFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDatabaseOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DatabaseOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDatabaseTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DatabaseTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDeleteColumnOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DeleteColumnOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDeleteFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DeleteFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDeleteOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DeleteOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDeleteRowOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DeleteRowOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDeleteTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DeleteTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDeliveredProcedureOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DeliveredProcedureOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDeploymentUnitOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DeploymentUnitOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDesktopOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DesktopOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDiffFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DiffFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDiffOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DiffOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDiffTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DiffTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDingdingOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DingdingOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDingtalkCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DingtalkCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDingtalkOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DingtalkOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDingtalkSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DingtalkSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDisconnectOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DisconnectOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDislikeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DislikeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDislikeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DislikeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDislikeTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DislikeTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDollarCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DollarCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDollarCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DollarCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDollarCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DollarCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDollarOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DollarOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDollarTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DollarTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDotChartOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DotChartOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDoubleLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DoubleLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDoubleRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DoubleRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDownCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DownCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDownCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DownCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDownCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DownCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDownOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DownOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDownSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DownSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDownSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DownSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDownSquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DownSquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDownloadOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DownloadOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDragOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DragOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDribbbleCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DribbbleCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDribbbleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DribbbleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDribbbleSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DribbbleSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDribbbleSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DribbbleSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDropboxCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DropboxCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDropboxOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DropboxOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconDropboxSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "DropboxSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEditFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EditFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEditOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EditOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEditTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EditTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEllipsisOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EllipsisOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEnterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EnterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEnvironmentFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EnvironmentFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEnvironmentOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EnvironmentOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEnvironmentTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EnvironmentTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEuroCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EuroCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEuroCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EuroCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEuroCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EuroCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEuroOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EuroOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEuroTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EuroTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExceptionOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExceptionOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExclamationCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExclamationCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExclamationCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExclamationCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExclamationCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExclamationCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExclamationOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExclamationOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExpandAltOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExpandAltOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExpandOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExpandOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExperimentFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExperimentFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExperimentOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExperimentOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExperimentTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExperimentTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconExportOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ExportOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEyeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EyeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEyeInvisibleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EyeInvisibleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEyeInvisibleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EyeInvisibleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEyeInvisibleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EyeInvisibleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEyeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EyeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconEyeTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "EyeTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFacebookFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FacebookFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFacebookOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FacebookOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFallOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FallOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFastBackwardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FastBackwardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFastBackwardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FastBackwardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFastForwardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FastForwardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFastForwardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FastForwardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFieldBinaryOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FieldBinaryOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFieldNumberOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FieldNumberOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFieldStringOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FieldStringOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFieldTimeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FieldTimeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileAddFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileAddFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileAddOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileAddOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileAddTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileAddTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileDoneOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileDoneOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileExcelFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileExcelFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileExcelOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileExcelOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileExcelTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileExcelTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileExclamationFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileExclamationFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileExclamationOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileExclamationOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileExclamationTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileExclamationTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileGifOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileGifOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileImageFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileImageFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileImageOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileImageOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileImageTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileImageTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileJpgOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileJpgOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileMarkdownFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileMarkdownFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileMarkdownOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileMarkdownOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileMarkdownTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileMarkdownTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilePdfFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilePdfFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilePdfOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilePdfOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilePdfTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilePdfTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilePptFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilePptFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilePptOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilePptOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilePptTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilePptTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileProtectOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileProtectOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileSearchOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileSearchOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileSyncOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileSyncOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileTextFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileTextFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileTextOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileTextOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileTextTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileTextTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileUnknownFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileUnknownFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileUnknownOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileUnknownOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileUnknownTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileUnknownTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileWordFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileWordFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileWordOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileWordOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileWordTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileWordTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileZipFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileZipFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileZipOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileZipOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFileZipTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FileZipTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilterFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilterFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFilterTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FilterTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFireFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FireFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFireOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FireOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFireTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FireTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFlagFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FlagFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFlagOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FlagOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFlagTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FlagTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderAddFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderAddFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderAddOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderAddOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderAddTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderAddTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderOpenFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderOpenFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderOpenOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderOpenOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderOpenTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderOpenTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFolderViewOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FolderViewOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFontColorsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FontColorsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFontSizeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FontSizeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconForkOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ForkOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFormOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FormOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFormatPainterFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FormatPainterFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFormatPainterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FormatPainterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconForwardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ForwardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconForwardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ForwardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFrownFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FrownFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFrownOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FrownOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFrownTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FrownTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFullscreenExitOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FullscreenExitOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFullscreenOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FullscreenOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFunctionOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FunctionOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFundFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FundFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFundOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FundOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFundProjectionScreenOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FundProjectionScreenOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFundTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FundTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFundViewOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FundViewOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFunnelPlotFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FunnelPlotFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFunnelPlotOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FunnelPlotOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconFunnelPlotTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "FunnelPlotTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGatewayOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GatewayOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGifOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GifOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGiftFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GiftFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGiftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GiftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGiftTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GiftTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGithubFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GithubFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGithubOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GithubOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGitlabFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GitlabFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGitlabOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GitlabOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGlobalOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GlobalOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGoldFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GoldFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGoldOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GoldOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGoldTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GoldTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGoldenFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GoldenFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGoogleCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GoogleCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGoogleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GoogleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGooglePlusCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GooglePlusCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGooglePlusOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GooglePlusOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGooglePlusSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GooglePlusSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGoogleSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GoogleSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconGroupOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "GroupOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHddFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HddFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHddOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HddOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHddTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HddTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHeartFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HeartFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHeartOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HeartOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHeartTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HeartTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHeatMapOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HeatMapOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHighlightFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HighlightFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHighlightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HighlightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHighlightTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HighlightTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHistoryOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HistoryOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHomeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HomeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHomeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HomeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHomeTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HomeTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHourglassFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HourglassFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHourglassOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HourglassOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHourglassTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "HourglassTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHtml5Filled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "Html5Filled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHtml5Outlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "Html5Outlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconHtml5TwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "Html5TwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconIdcardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "IdcardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconIdcardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "IdcardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconIdcardTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "IdcardTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconIeCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "IeCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconIeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "IeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconIeSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "IeSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconImportOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ImportOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInboxOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InboxOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInfoCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InfoCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInfoCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InfoCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInfoCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InfoCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInfoOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InfoOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInsertRowAboveOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InsertRowAboveOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInsertRowBelowOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InsertRowBelowOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInsertRowLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InsertRowLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInsertRowRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InsertRowRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInstagramFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InstagramFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInstagramOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InstagramOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInsuranceFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InsuranceFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInsuranceOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InsuranceOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInsuranceTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InsuranceTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInteractionFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InteractionFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInteractionOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InteractionOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconInteractionTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "InteractionTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconIssuesCloseOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "IssuesCloseOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconItalicOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ItalicOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconKeyOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "KeyOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLaptopOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LaptopOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLayoutFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LayoutFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLayoutOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LayoutOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLayoutTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LayoutTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLeftCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LeftCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLeftCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LeftCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLeftCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LeftCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLeftSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LeftSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLeftSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LeftSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLeftSquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LeftSquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLikeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LikeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLikeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LikeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLikeTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LikeTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLineChartOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LineChartOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLineHeightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LineHeightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLineOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LineOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLinkOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LinkOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLinkedinFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LinkedinFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLinkedinOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LinkedinOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLoading3QuartersOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "Loading3QuartersOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLoadingOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LoadingOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLockFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LockFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLockOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LockOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLockTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LockTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLoginOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LoginOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconLogoutOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "LogoutOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMacCommandFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MacCommandFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMacCommandOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MacCommandOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMailFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MailFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMailOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MailOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMailTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MailTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconManOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ManOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMedicineBoxFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MedicineBoxFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMedicineBoxOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MedicineBoxOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMedicineBoxTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MedicineBoxTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMediumCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MediumCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMediumOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MediumOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMediumSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MediumSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMediumWorkmarkOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MediumWorkmarkOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMehFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MehFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMehOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MehOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMehTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MehTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMenuFoldOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MenuFoldOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMenuOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MenuOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMenuUnfoldOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MenuUnfoldOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMergeCellsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MergeCellsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMessageFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MessageFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMessageOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MessageOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMessageTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MessageTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMinusCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MinusCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMinusCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MinusCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMinusCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MinusCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMinusOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MinusOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMinusSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MinusSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMinusSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MinusSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMinusSquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MinusSquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMobileFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MobileFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMobileOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MobileOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMobileTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MobileTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMoneyCollectFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MoneyCollectFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMoneyCollectOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MoneyCollectOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMoneyCollectTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MoneyCollectTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMonitorOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MonitorOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconMoreOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "MoreOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconNodeCollapseOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "NodeCollapseOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconNodeExpandOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "NodeExpandOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconNodeIndexOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "NodeIndexOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconNotificationFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "NotificationFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconNotificationOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "NotificationOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconNotificationTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "NotificationTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconNumberOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "NumberOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconOneToOneOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "OneToOneOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconOrderedListOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "OrderedListOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPaperClipOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PaperClipOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPartitionOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PartitionOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPauseCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PauseCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPauseCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PauseCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPauseCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PauseCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPauseOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PauseOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPayCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PayCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPayCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PayCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPercentageOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PercentageOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPhoneFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PhoneFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPhoneOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PhoneOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPhoneTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PhoneTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPicCenterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PicCenterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPicLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PicLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPicRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PicRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPictureFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PictureFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPictureOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PictureOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPictureTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PictureTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPieChartFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PieChartFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPieChartOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PieChartOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPieChartTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PieChartTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlayCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlayCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlayCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlayCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlayCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlayCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlaySquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlaySquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlaySquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlaySquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlaySquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlaySquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlusCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlusCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlusCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlusCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlusCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlusCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlusOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlusOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlusSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlusSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlusSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlusSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPlusSquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PlusSquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPoundCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PoundCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPoundCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PoundCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPoundCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PoundCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPoundOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PoundOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPoweroffOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PoweroffOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPrinterFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PrinterFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPrinterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PrinterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPrinterTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PrinterTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconProfileFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ProfileFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconProfileOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ProfileOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconProfileTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ProfileTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconProjectFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ProjectFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconProjectOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ProjectOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconProjectTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ProjectTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPropertySafetyFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PropertySafetyFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPropertySafetyOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PropertySafetyOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPropertySafetyTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PropertySafetyTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPullRequestOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PullRequestOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPushpinFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PushpinFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPushpinOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PushpinOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconPushpinTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "PushpinTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconQqCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "QqCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconQqOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "QqOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconQqSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "QqSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconQrcodeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "QrcodeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconQuestionCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "QuestionCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconQuestionCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "QuestionCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconQuestionCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "QuestionCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconQuestionOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "QuestionOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRadarChartOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RadarChartOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRadiusBottomleftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RadiusBottomleftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRadiusBottomrightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RadiusBottomrightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRadiusSettingOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RadiusSettingOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRadiusUpleftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RadiusUpleftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRadiusUprightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RadiusUprightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconReadFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ReadFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconReadOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ReadOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconReconciliationFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ReconciliationFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconReconciliationOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ReconciliationOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconReconciliationTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ReconciliationTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRedEnvelopeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RedEnvelopeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRedEnvelopeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RedEnvelopeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRedEnvelopeTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RedEnvelopeTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRedditCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RedditCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRedditOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RedditOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRedditSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RedditSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRedoOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RedoOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconReloadOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ReloadOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRestFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RestFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRestOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RestOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRestTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RestTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRetweetOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RetweetOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRightCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RightCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRightCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RightCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRightCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RightCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRightSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RightSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRightSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RightSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRightSquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RightSquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRiseOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RiseOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRobotFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RobotFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRobotOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RobotOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRocketFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RocketFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRocketOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RocketOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRocketTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RocketTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRollbackOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RollbackOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRotateLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RotateLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconRotateRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "RotateRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSafetyCertificateFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SafetyCertificateFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSafetyCertificateOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SafetyCertificateOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSafetyCertificateTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SafetyCertificateTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSafetyOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SafetyOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSaveFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SaveFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSaveOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SaveOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSaveTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SaveTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconScanOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ScanOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconScheduleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ScheduleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconScheduleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ScheduleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconScheduleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ScheduleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconScissorOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ScissorOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSearchOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SearchOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSecurityScanFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SecurityScanFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSecurityScanOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SecurityScanOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSecurityScanTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SecurityScanTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSelectOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SelectOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSendOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SendOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSettingFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SettingFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSettingOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SettingOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSettingTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SettingTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShakeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShakeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShareAltOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShareAltOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShopFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShopFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShopOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShopOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShopTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShopTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShoppingCartOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShoppingCartOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShoppingFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShoppingFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShoppingOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShoppingOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShoppingTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShoppingTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconShrinkOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ShrinkOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSignalFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SignalFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSisternodeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SisternodeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSketchCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SketchCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSketchOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SketchOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSketchSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SketchSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSkinFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SkinFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSkinOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SkinOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSkinTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SkinTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSkypeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SkypeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSkypeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SkypeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSlackCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SlackCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSlackOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SlackOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSlackSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SlackSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSlackSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SlackSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSlidersFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SlidersFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSlidersOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SlidersOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSlidersTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SlidersTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSmallDashOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SmallDashOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSmileFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SmileFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSmileOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SmileOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSmileTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SmileTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSnippetsFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SnippetsFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSnippetsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SnippetsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSnippetsTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SnippetsTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSolutionOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SolutionOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSortAscendingOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SortAscendingOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSortDescendingOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SortDescendingOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSoundFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SoundFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSoundOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SoundOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSoundTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SoundTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSplitCellsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SplitCellsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStarFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StarFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStarOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StarOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStarTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StarTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStepBackwardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StepBackwardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStepBackwardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StepBackwardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStepForwardFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StepForwardFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStepForwardOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StepForwardOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStockOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StockOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStopFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StopFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStopOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StopOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStopTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StopTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconStrikethroughOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "StrikethroughOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSubnodeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SubnodeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSwapLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SwapLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSwapOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SwapOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSwapRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SwapRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSwitcherFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SwitcherFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSwitcherOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SwitcherOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSwitcherTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SwitcherTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconSyncOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "SyncOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTableOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TableOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTabletFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TabletFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTabletOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TabletOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTabletTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TabletTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTagFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TagFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTagOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TagOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTagTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TagTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTagsFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TagsFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTagsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TagsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTagsTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TagsTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTaobaoCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TaobaoCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTaobaoCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TaobaoCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTaobaoOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TaobaoOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTaobaoSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TaobaoSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTeamOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TeamOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconThunderboltFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ThunderboltFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconThunderboltOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ThunderboltOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconThunderboltTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ThunderboltTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconToTopOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ToTopOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconToolFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ToolFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconToolOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ToolOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconToolTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ToolTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTrademarkCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TrademarkCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTrademarkCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TrademarkCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTrademarkCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TrademarkCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTrademarkOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TrademarkOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTransactionOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TransactionOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTranslationOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TranslationOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTrophyFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TrophyFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTrophyOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TrophyOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTrophyTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TrophyTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTwitterCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TwitterCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTwitterOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TwitterOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconTwitterSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "TwitterSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUnderlineOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UnderlineOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUndoOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UndoOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUngroupOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UngroupOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUnlockFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UnlockFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUnlockOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UnlockOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUnlockTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UnlockTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUnorderedListOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UnorderedListOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUpCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UpCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUpCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UpCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUpCircleTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UpCircleTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUpOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UpOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUpSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UpSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUpSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UpSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUpSquareTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UpSquareTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUploadOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UploadOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUsbFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UsbFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUsbOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UsbOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUsbTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UsbTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUserAddOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UserAddOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUserDeleteOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UserDeleteOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUserOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UserOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUserSwitchOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UserSwitchOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUsergroupAddOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UsergroupAddOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconUsergroupDeleteOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "UsergroupDeleteOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVerifiedOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VerifiedOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVerticalAlignBottomOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VerticalAlignBottomOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVerticalAlignMiddleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VerticalAlignMiddleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVerticalAlignTopOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VerticalAlignTopOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVerticalLeftOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VerticalLeftOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVerticalRightOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VerticalRightOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVideoCameraAddOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VideoCameraAddOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVideoCameraFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VideoCameraFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVideoCameraOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VideoCameraOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconVideoCameraTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "VideoCameraTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWalletFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WalletFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWalletOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WalletOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWalletTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WalletTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWarningFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WarningFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWarningOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WarningOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWarningTwoTone (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WarningTwoTone" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWechatFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WechatFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWechatOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WechatOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWeiboCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WeiboCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWeiboCircleOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WeiboCircleOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWeiboOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WeiboOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWeiboSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WeiboSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWeiboSquareOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WeiboSquareOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWhatsAppOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WhatsAppOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWifiOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WifiOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWindowsFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WindowsFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWindowsOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WindowsOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconWomanOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "WomanOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconYahooFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "YahooFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconYahooOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "YahooOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconYoutubeFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "YoutubeFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconYoutubeOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "YoutubeOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconYuqueFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "YuqueFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconYuqueOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "YuqueOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconZhihuCircleFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ZhihuCircleFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconZhihuOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ZhihuOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconZhihuSquareFilled (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ZhihuSquareFilled" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconZoomInOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ZoomInOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children
    let inline antIconZoomOutOutlined (props: AntIcon list) (children: ReactElement list): ReactElement =
        ofImport "ZoomOutOutlined" "@ant-design/icons" (keyValueList CaseRules.LowerFirst props) children