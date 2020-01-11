namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React.Helpers
open Fable.React
open Browser.Types

/// import declarations for `Select` and its nested components.
/// For more information, refer to the [official documentation](https://ant.design/components/select/)
[<AutoOpen>]
module Select =
    [<RequireQualifiedAccess>]
    type AntOption =
        | Disabled of bool
        | Key of string
        | Title of string
        | Value of string
        static member Custom (key: string, value: obj): AntOption = unbox(key, value)
        static member Style (css: Props.CSSProp list): AntOption = unbox ("style", keyValueList CaseRules.LowerFirst css)        

    let inline antOption (props: AntOption list) (children: ReactElement list): ReactElement =
       ofImport "Select.Option" "antd" (keyValueList CaseRules.LowerFirst props) children
    
    [<RequireQualifiedAccess>]
    type AntOptGroup =
        | Key of string
        | Value of U2<string, ReactElement>
        static member Custom (key: string, value: obj): AntOptGroup = unbox(key, value)
        static member Style (css: Props.CSSProp list) : AntOptGroup = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antOptGroup (props: AntOptGroup list) (children: ReactElement list): ReactElement =
        ofImport "Select.OptGroup" "antd" (keyValueList CaseRules.LowerFirst props) children

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type SelectMode  =
        | Multiple
        | ComboBox
        | [<CompiledName("tags")>] Tag
        | Default

    [<RequireQualifiedAccess>]
    type AntSelect =
        /// Show clear button. Default = false
        | AllowClear of bool
        /// Get focus by default. Default = false
        | AutoFocus of bool
        /// Whether active first option by default. Default = true
        | DefaultActiveFirstOption of bool
        /// Initial selected option.
        | DefaultValue of string
        /// Whether disabled select. Default = false
        | Disabled of bool
        /// className of dropdown menu
        | DropdownClassName of string
        /// Whether dropdown's with is same with select. Default = true
        | DropdownMatchSelectWidth of bool
        /// If true, filter options by input, if function, filter options against it.
        /// The function will receive two arguments, inputValue and option,
        /// if the function returns true, the option will be included in the filtered set;
        /// Otherwise, it will be excluded. Default = true
        | FilterOption of U2<bool, string -> string -> bool>
        /// Value of action option by default
        | FirstActiveValue of U2<string, string list>
        /// Parent Node which the selector should be rendered to. Default to body.
        /// When position issues happen, try to modify it into scrollable content and position it relative.
        /// [Example](https://codesandbox.io/s/4j168r7jw0)
        | GetPopupContainer of (ReactElement -> unit)
        /// whether to embed label in value, turn the format of value
        /// from `string` to `{key: string, label: ReactNode}`. Default: false
        | LabelInValue of bool
        /// Max tag count to show
        | MaxTagCount of float
        /// Placeholder for not showing tags. Can be a replacement node or
        /// a compensation function that works on omitted values
        | MaxTagPlaceholder of U2<ReactElement, (string list -> unit)>
        /// Set mode of Select (Support after 2.9)
        | Mode of SelectMode
        /// Specify content to show when no result matches.
        /// Default: 'Not Found'
        | NotFoundContent of string
        /// Which prop value of option will be used for filter if filterOption is true
        | OptionFilterProp of string
        | OptionLabelProp of string
        /// Placeholder of select
        | Placeholder of ReactElement
        /// Whether show search input in single mode.
        | ShowSearch of bool
        /// Whether to show the drop-down arrow
        | ShowArrow of bool
        /// Size of Select input
        | Size of Size
        /// Separator used to tokenize on tag/multiple mode
        | TokenSeparators of string list
        /// Current selected option.
        | Value of string
        /// Called when blur
        | OnBlur of (Event -> unit)
        /// Called when select an option or input value change, or value of input
        /// is changed in combobox mode
        | OnChange of (string array -> unit)
        /// Called when a option is deselected, the params are option's value (or key).
        /// only called for multiple or tags, effective in multiple or tags mode only.
        | OnDeselect of (string -> unit)
        /// Called when focus
        | OnFocus of (Event -> unit)
        /// Called when key pressed
        | OnInputKeyDown of (KeyboardEvent -> unit)
        /// Called when mouse enter
        | OnMouseEnter of (MouseEvent -> unit)
        /// Called when mouse leave
        | OnMouseLeave of (MouseEvent -> unit)
        /// Called when dropdown scrolls
        | OnPopupScroll of (Event -> unit)
        /// Callback function that is fired when input changed.
        | OnSearch of (string -> unit)
        | OnSelect of (string -> unit)
        static member Custom (key: string, value: obj): AntSelect = unbox(key, value)
        static member Style (css: Props.CSSProp list): AntSelect = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antSelect (props: AntSelect list) (children: ReactElement list): ReactElement =
        ofImport "Select" "antd" (keyValueList CaseRules.LowerFirst props) children