module Fable.AntD.Builders.Ant

open Fable.AntD.Builders

let div = Html.DomElementBuilder("div")
let span = Html.DomElementBuilder("span")
let fragment = Html.FragmentBuilder()

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



let tooltip = Tooltip.TooltipBuilder()
let popOver = Tooltip.PopoverBuilder()
let popConfirm = Tooltip.PopconfirmBuilder()
