module Fable.Builders.AntDesign.Ant

open Fable.Builders.AntDesign

let str (text: string) = Feliz.Html.text text

let button = Button.ButtonBuilder()
let buttonGroup = Button.ButtonGroupBuilder()

let customIcon = Icon.IconBuilder(Icon.CustomIcon)
let basicIcon glyph = Icon.IconBuilder(glyph)
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
let col = Grid.ColBuilder()

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

let input = Input.InputBuilder()
let password = Input.PasswordBuilder()
let search = Input.SearchBuilder()
let textArea = Input.TextAreaBuilder()
let inputGroup = Input.InputGroupBuilder()

let inputNumber = InputNumber.InputNumberBuilder()

let mentions = Mentions.MentionsBuilder()
let mention = Mentions.MentionBuilder()

let radio<'T> = Radio.RadioBuilder<'T>()
let radioButton<'T> = Radio.RadioButtonBuilder<'T>()
let radioGroup<'T> = Radio.RadioGroupBuilder<'T>()

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

let avatar = Avatar.AvatarBuilder()

let badge = Badge.BadgeBuilder()

let calendar = Calendar.CalendarBuilder()

let card = Card.CardBuilder()
let cardGrid = Card.CardGridBuilder()
let cardMeta = Card.CardMetaBuilder()

let carousel = Carousel.CarouselBuilder()

let comment = Comment.CommentBuilder()

let descriptions = Descriptions.DescriptionsBuilder()
let description = Descriptions.DescriptionBuilder()

let empty = Empty.EmptyBuilder()

let list<'T> = List.ListBuilder<'T>()
let listItem = List.ListItemBuilder()
let listMeta = List.ListItemMetaBuilder()

let statistic = Statistic.StatisticBuilder()
let countdown = Statistic.StatisticCountdownBuilder()

let table<'T> = Table.TableBuilder<'T>()
let tableColumn<'T>= Table.TableColumnBuilder<'T>()
let tableColumnGroup = Table.TableColumnGroupBuilder()

let tabs = Tabs.TabsBuilder()
let tabPane = Tabs.TabPaneBuilder()

let tag = Tag.TagBuilder()
let checkableTag = Tag.CheckableTagBuilder()

let timeline = Timeline.TimelineBuilder()
let timelineItem = Timeline.TimelineItemBuilder()

let tree<'T> = Tree.TreeBuilder<'T>()
let directoryTree<'T> = Tree.DirectoryTreeBuilder<'T>()
let treeNode = Tree.TreeNodeBuilder()

let alert = Alert.AlertBuilder()
let alertErrorBoundary = Alert.AlertErrorBoundaryBuilder()

let drawer = Drawer.DrawerBuilder()

let message = Message.MessageBuilder()

let modal = Modal.ModalBuilder()

let notification = Notification.NotificationBuilder()

let tooltip = Tooltip.TooltipBuilder()
let popOver = Tooltip.PopOverBuilder()
let popConfirm = Tooltip.PopConfirmBuilder()

let progress = Progress.ProgressBuilder()

let result = Result.ResultBuilder()

let skeleton = Skeleton.SkeletonBuilder()
let skeletonAvatar = Skeleton.SkeletonAvatarBuilder()
let skeletonButton = Skeleton.SkeletonButtonBuilder()
let skeletonInput = Skeleton.SkeletonInputBuilder()
let skeletonParagraph = Skeleton.SkeletonParagraphBuilder()
let skeletonTitle = Skeleton.SkeletonTitleBuilder()

let spin = Spin.SpinBuilder()

let anchor = Anchor.AnchorBuilder()
let anchorLink = Anchor.AnchorLinkBuilder()

let backTop = BackTop.BackTopBuilder()

let configProvider = ConfigProvider.ConfigProviderBuilder()