module Fable.AntDesign.Examples.Pages.TablePage

open Fable.Builders.React
open Fable.Builders.AntDesign
open Fable.AntDesign.Examples.Components.Example
open Feliz

type item =
    { key: string
      firstName: string
      lastName: string
      age: int
      address: string
      tags: string list }

let view model =
    Example {
        name "Basic Layout"
        sourceUrl "Pages/LayoutPage.fs"
        sourceRange (15, 42)

        let data = [|
          { key = "1"
            firstName = "John"
            lastName = "Brown"
            age = 32
            address = "New York No. 1 Lake Park"
            tags = ["nice"; "developer"] }
          { key = "2"
            firstName = "Jim"
            lastName = "Green"
            age = 42
            address = "London No. 1 Lake Park"
            tags = ["loser"] }
          { key = "3"
            firstName = "Joe"
            lastName = "Black"
            age = 32
            address = "Sidney No. 1 Lake Park"
            tags = ["cool"; "teacher"] }
        |]
        
        Table {
            dataSource data
            TableColumnGroup {
                title (str "Name")
                TableColumn {
                    title (str "First Name")
                    dataIndex "firstName"
                    key "firstName"
                }
                TableColumn {
                    title (str "Last Name")
                    dataIndex "lastName"
                    key "lastName"
                }
            }
            TableColumn { title (str "Age"); dataIndex "age"; key "age" }
            TableColumn { title (str "Address"); dataIndex "address"; key "address" }
            TableColumn<string list, item> {
                title (str "Tags")
                dataIndex "tags"
                key "tags"
                render (fun a b c ->
                    div {
                        for tag in a do
                            Tag {
                                color "blue"
                                str tag
                            }
                        })
            }
            TableColumn<unit, item> {
                title (str "Action")
                key "action"
                render (fun text record b -> 
                    Space {
                        size SpaceSize.Middle
                        Button { buttonType ButtonType.Link; str $"Invite {record.lastName}" }
                        Button { buttonType ButtonType.Link; str "Delete" }
                    })
            }
        }
    }