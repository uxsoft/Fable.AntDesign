[<Microsoft.FSharp.Core.AutoOpen>]
module Fable.Builders.AntDesign.Ant

open Fable.Builders.AntDesign

let str (text: string) = Feliz.Html.text text

let Button = Button.ButtonBuilder()
let ButtonGroup = Fable.Builders.AntDesign.Button.ButtonGroupBuilder()

let CustomIcon = Icon.IconBuilder(Icon.CustomIcon)
let BasicIcon glyph = Icon.IconBuilder(glyph)
let Icons = Icon.BasicIcons

let Text = Typography.TextBuilder()
let Title = Typography.TitleBuilder()
let Paragraph = Typography.ParagraphBuilder()
let Link = Typography.LinkBuilder()
let CopyableWith = Typography.CopyableConfigBuilder()
let EllipsisWith = Typography.EllipsisConfigBuilder()
let EditableWith = Typography.EditableConfigBuilder()

let Divider = Divider.DividerBuilder()

let Row = Grid.RowBuilder()
let Col = Grid.ColBuilder()

let Layout = Layout.LayoutBuilder()
let Header = Fable.Builders.AntDesign.Layout.HeaderBuilder()
let Content = Fable.Builders.AntDesign.Layout.ContentBuilder()
let Footer = Fable.Builders.AntDesign.Layout.FooterBuilder()
let Sider = Fable.Builders.AntDesign.Layout.SiderBuilder()

let Space = Space.SpaceBuilder()

let Affix = Affix.AffixBuilder()

let Breadcrumb = Breadcrumb.BreadcrumbBuilder()
let BreadcrumbItem = Fable.Builders.AntDesign.Breadcrumb.BreadcrumbItemBuilder()
let BreadcrumbSeparator = Fable.Builders.AntDesign.Breadcrumb.BreadcrumbSeparatorBuilder()

let Dropdown = Dropdown.DropdownBuilder()
let DropdownButton = Fable.Builders.AntDesign.Dropdown.DropdownButtonBuilder()

let Menu = Menu.MenuBuilder()
let MenuDivider = Fable.Builders.AntDesign.Menu.MenuDividerBuilder()
let MenuItem = Fable.Builders.AntDesign.Menu.MenuItemBuilder()
let MenuItemGroup = Fable.Builders.AntDesign.Menu.MenuItemGroupBuilder()
let MenuSubMenu = Fable.Builders.AntDesign.Menu.MenuSubMenuBuilder()

let PageHeader = PageHeader.PageHeaderBuilder()

let Pagination = Pagination.PaginationBuilder()

let Steps = Steps.StepsBuilder()
let Step = Fable.Builders.AntDesign.Steps.StepBuilder()

let AutoComplete<'T> = AutoComplete.AutoCompleteBuilder<'T>()
let AutoCompleteOption<'T> = Fable.Builders.AntDesign.AutoComplete.AutoCompleteOptionBuilder<'T>()

let Cascader = Cascader.CascaderBuilder()

let Checkbox = Checkbox.CheckboxBuilder()
let CheckboxGroup = Fable.Builders.AntDesign.Checkbox.CheckboxGroupBuilder()

let DatePicker = DatePicker.DatePickerBuilder()
let MonthPicker = Fable.Builders.AntDesign.DatePicker.MonthPickerBuilder()
let WeekPicker = Fable.Builders.AntDesign.DatePicker.WeekPickerBuilder()
let QuarterPicker = Fable.Builders.AntDesign.DatePicker.QuarterPickerBuilder()
let YearPicker = Fable.Builders.AntDesign.DatePicker.YearPickerBuilder()
let DateRangePicker = Fable.Builders.AntDesign.DatePicker.DateRangePickerBuilder()

let Form<'T> = Form.FormBuilder<'T>()
let FormErrorList = Fable.Builders.AntDesign.Form.FormErrorListBuilder()
let FormItem = Fable.Builders.AntDesign.Form.FormItemBuilder()
let FormList = Fable.Builders.AntDesign.Form.FormListBuilder()
let FormProvider = Fable.Builders.AntDesign.Form.FormProviderBuilder()

let Input = Input.InputBuilder()
let Password = Fable.Builders.AntDesign.Input.PasswordBuilder()
let Search = Fable.Builders.AntDesign.Input.SearchBuilder()
let TextArea = Fable.Builders.AntDesign.Input.TextAreaBuilder()
let InputGroup = Fable.Builders.AntDesign.Input.InputGroupBuilder()

let InputNumber = InputNumber.InputNumberBuilder()

let Mentions = Mentions.MentionsBuilder()
let Mention = Fable.Builders.AntDesign.Mentions.MentionBuilder()

let Radio<'T> = Radio.RadioBuilder<'T>()
let RadioButton<'T> = Fable.Builders.AntDesign.Radio.RadioButtonBuilder<'T>()
let RadioGroup<'T> = Fable.Builders.AntDesign.Radio.RadioGroupBuilder<'T>()

let Rate = Rate.RateBuilder()

let Select<'T> = Select.SelectBuilder<'T>()
let SelectOptGroup = Fable.Builders.AntDesign.Select.SelectOptGroupBuilder()
let SelectOption = Fable.Builders.AntDesign.Select.SelectOptionBuilder()

let Slider = Slider.SliderBuilder()

let Switch = Switch.SwitchBuilder()

let TimePicker = TimePicker.TimePickerBuilder()
let TimeRangePicker = Fable.Builders.AntDesign.TimePicker.TimeRangePickerBuilder()

let Transfer = Transfer.TransferBuilder()

let TreeSelect = TreeSelect.TreeSelectBuilder()
let TreeSelectNode = Fable.Builders.AntDesign.TreeSelect.TreeSelectNodeBuilder()

let Upload = Upload.UploadBuilder()

let Avatar = Avatar.AvatarBuilder()

let Badge = Badge.BadgeBuilder()

let Calendar = Calendar.CalendarBuilder()

let Card = Fable.Builders.AntDesign.Card.CardBuilder()
let CardGrid = Fable.Builders.AntDesign.Card.CardGridBuilder()
let CardMeta = Fable.Builders.AntDesign.Card.CardMetaBuilder()

let Carousel = Fable.Builders.AntDesign.Carousel.CarouselBuilder()

let CollapsePanel = Fable.Builders.AntDesign.Collapse.CollapsePanelBuilder()
let Collapse = Fable.Builders.AntDesign.Collapse.CollapseBuilder()


let Comment = Fable.Builders.AntDesign.Comment.CommentBuilder()

let Descriptions = Fable.Builders.AntDesign.Descriptions.DescriptionsBuilder()
let Description = Fable.Builders.AntDesign.Descriptions.DescriptionBuilder()

let Empty = Empty.EmptyBuilder()

let Image = Image.ImageBuilder()

let List<'T> = List.ListBuilder<'T>()
let ListItem = Fable.Builders.AntDesign.List.ListItemBuilder()
let ListItemMeta = Fable.Builders.AntDesign.List.ListItemMetaBuilder()

let Statistic = Statistic.StatisticBuilder()
let Countdown = Fable.Builders.AntDesign.Statistic.StatisticCountdownBuilder()

let Table<'T> = Table.TableBuilder<'T>()
let TableColumn<'TColumn, 'TRecord> = Fable.Builders.AntDesign.Table.TableColumnBuilder<'TColumn, 'TRecord>()
let TableColumnGroup = Fable.Builders.AntDesign.Table.TableColumnGroupBuilder()

let Tabs = Tabs.TabsBuilder()
let TabPane = Fable.Builders.AntDesign.Tabs.TabPaneBuilder()

let Tag = Tag.TagBuilder()
let CheckableTag = Fable.Builders.AntDesign.Tag.CheckableTagBuilder()

let Timeline = Timeline.TimelineBuilder()
let TimelineItem = Fable.Builders.AntDesign.Timeline.TimelineItemBuilder()

let Tree<'T> = Tree.TreeBuilder<'T>()
let DirectoryTree<'T> = Fable.Builders.AntDesign.Tree.DirectoryTreeBuilder<'T>()
let TreeNode = Fable.Builders.AntDesign.Tree.TreeNodeBuilder()

let Alert = Alert.AlertBuilder()
let AlertErrorBoundary = Fable.Builders.AntDesign.Alert.AlertErrorBoundaryBuilder()

let Drawer = Drawer.DrawerBuilder()

let Message = Message.MessageBuilder()

let Modal = Modal.ModalBuilder()

let Notification = Notification.NotificationBuilder()

let Tooltip = Tooltip.TooltipBuilder()
let PopOver = Fable.Builders.AntDesign.Tooltip.PopOverBuilder()
let PopConfirm = Fable.Builders.AntDesign.Tooltip.PopConfirmBuilder()

let Progress = Progress.ProgressBuilder()

let Result = Result.ResultBuilder()

let Skeleton = Skeleton.SkeletonBuilder()
let SkeletonAvatar = Fable.Builders.AntDesign.Skeleton.SkeletonAvatarBuilder()
let SkeletonButton = Fable.Builders.AntDesign.Skeleton.SkeletonButtonBuilder()
let SkeletonInput = Fable.Builders.AntDesign.Skeleton.SkeletonInputBuilder()
let SkeletonParagraph = Fable.Builders.AntDesign.Skeleton.SkeletonParagraphBuilder()
let SkeletonTitle = Fable.Builders.AntDesign.Skeleton.SkeletonTitleBuilder()

let Spin = Spin.SpinBuilder()

let Anchor = Anchor.AnchorBuilder()
let AnchorLink = Fable.Builders.AntDesign.Anchor.AnchorLinkBuilder()

let BackTop = BackTop.BackTopBuilder()

let ConfigProvider = ConfigProvider.ConfigProviderBuilder()