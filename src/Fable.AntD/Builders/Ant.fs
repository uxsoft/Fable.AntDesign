module Fable.AntD.Builders.Ant

open Fable.AntD.Builders

let str = Fable.React.Helpers.str
//TODO FragmentBuilder

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

let layout = Layout.LayoutBuilder()
let header = Layout.HeaderBuilder()
let content = Layout.ContentBuilder()
let footer = Layout.FooterBuilder()
let sider = Layout.SiderBuilder()
let tooltip = Tooltip.TooltipBuilder()
let popOver = Tooltip.PopoverBuilder()
let popConfirm = Tooltip.PopconfirmBuilder()
let paginationProps = Pagination.PaginationPropsBuilder()
let pagination = Pagination.PaginationBuilder()