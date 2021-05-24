module Fable.AntD.Builders.Ant

open Fable.AntD.Builders

let div = Html.DomElementBuilder("div")
let span = Html.DomElementBuilder("span")
let fragment = Html.FragmentBuilder()
let str = Fable.React.Helpers.str

let button = Button.ButtonBuilder()
let buttonProps = Button.ButtonPropsBuilder()
let buttonGroup = Button.ButtonGroupBuilder()

let customIcon = Icon.IconBuilder(Icon.CustomIcon)
let icon glyph = Icon.IconBuilder(glyph)
let icons = Icon.BasicIcons

let text = Typography.TextBuilder()
let title = Typography.TitleBuilder()
let paragraph = Typography.ParagraphBuilder()
let link = Typography.LinkBuilder()
let copyableWith = Typography.CopyableConfigBuilder()
let ellipsisWith = Typography.EllipsisConfigBuilder()
let editableWith = Typography.EditableConfigBuilder()

let divider = Divider.DividerBuilder()

let row = Grid.RowBuilder()
let col = Grid.ColumnBuilder()

let layout = Layout.LayoutBuilder()
let header = Layout.HeaderBuilder()
let content = Layout.ContentBuilder()
let footer = Layout.FooterBuilder()
let sider = Layout.SiderBuilder()

let space = Space.SpaceBuilder()

let affix = Affix.AffixBuilder()

let breadcrumb = Breadcrumb.BreadcrumbBuilder()
let breadcrumbItem = Breadcrumb.BreadcrumbItemBuilder()
let breadcrumbSeparator = Breadcrumb.BreadcrumbSeparatorBuilder()

let dropdown = Dropdown.DropdownBuilder()
let dropdownButton = Dropdown.DropdownButtonBuilder()

let menu = Menu.MenuBuilder()
let menuDivider = Menu.MenuDividerBuilder()
let menuItem = Menu.MenuItemBuilder()
let menuItemGroup = Menu.MenuItemGroupBuilder()
let menuSubMenu = Menu.MenuSubMenuBuilder()

let pageHeader = PageHeader.PageHeaderBuilder()

let paginationProps = Pagination.PaginationPropsBuilder()
let pagination = Pagination.PaginationBuilder()

let steps = Steps.StepsBuilder()
let step = Steps.StepBuilder()

let autoComplete = AutoComplete.AutoCompleteBuilder()
let autoCompleteOption = AutoComplete.AutoCompleteOptionBuilder()

let cascader = Cascader.CascaderBuilder()

let checkbox = Checkbox.CheckboxBuilder()
let checkboxGroup = Checkbox.CheckboxGroupBuilder()

let datePicker = DatePicker.DatePickerBuilder()
let monthPicker = DatePicker.MonthPickerBuilder()
let weekPicker = DatePicker.WeekPickerBuilder()
let quarterPicker = DatePicker.QuarterPickerBuilder()
let yearPicker = DatePicker.YearPickerBuilder()
let dateRangePicker = DatePicker.DateRangePickerBuilder()

let form<'T> = Form.FormBuilder<'T>()
let formErrorList = Form.FormErrorListBuilder()
let formItem = Form.FormItemBuilder()
let formList = Form.FormListBuilder()
let formProvider = Form.FormProviderBuilder()
let formRule = Form.FormRuleBuilder()

let input = Input.InputBuilder()
let password = Input.PasswordBuilder()
let search = Input.SearchBuilder()
let textArea = Input.TextAreaBuilder()
let inputGroup = Input.InputGroupBuilder()

let inputNumber = InputNumber.InputNumberBuilder()

let mentions = Mentions.MentionsBuilder()
let mention = Mentions.MentionBuilder()

let radio = Radio.RadioBuilder()
let radioButton = Radio.RadioButtonBuilder()
let radioGroup = Radio.RadioGroupBuilder()

let rate = Rate.RateBuilder()

let select<'T> = Select.SelectBuilder()
let selectOptGroup = Select.SelectOptGroupBuilder()
let selectOption = Select.SelectOptionBuilder()

let slider = Slider.SliderBuilder()

let switch = Switch.SwitchBuilder()

let timePicker = TimePicker.TimePickerBuilder()
let timeRangePicker = TimePicker.TimeRangePickerBuilder()

let transfer = Transfer.TransferBuilder()

let treeSelect = TreeSelect.TreeSelectBuilder()
let treeSelectNode = TreeSelect.TreeSelectNodeBuilder()

let upload = Upload.UploadBuilder()

let tooltip = Tooltip.TooltipBuilder()
let popOver = Tooltip.PopoverBuilder()
let popConfirm = Tooltip.PopconfirmBuilder()
