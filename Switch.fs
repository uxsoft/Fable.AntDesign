namespace Fable.AntD

open Browser.Types
open Fable.React

    type Switch() =
        inherit AntElement("Switch")
        member x.AutoFocus with set (v: bool) = x.Attribute "autoFocus" v
        member x.Checked with set (v: bool) = x.Attribute "checked" v
        member x.CheckedChildren with set (v: ReactElement) = x.Attribute "checkedChildren" v
        member x.DefaultChecked with set (v: bool) = x.Attribute "defaultChecked" v
        member x.Disabled with set (v: bool) = x.Attribute "disabled" v
        member x.Loading with set (v: bool) = x.Attribute "loading" v
        member x.Size with set (v: Size  ) = x.Attribute "size" v
        member x.UnCheckedChildren with set (v: ReactElement) = x.Attribute "unCheckedChildren" v
        member x.OnChange with set (v: (bool -> Event->unit)) = x.Attribute "onChange" v
        member x.OnClick with set (v: (bool -> Event->unit)) = x.Attribute "onClick" v
        member x.ClassName with set (v: string) = x.Attribute "className" v