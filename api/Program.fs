open Saturn
open Giraffe
open Logic
open Giraffe.ViewEngine

let indexView =
  html [] [
    head [] [ title [] [ str "Saturn Sample" ] ]
    body [] [
      h1 [] [ str "I |> F#" ]
      p [ _class "some-css-class"; _id "someId" ] [ str "Hello World" ]
    ]
  ]

let defaultPage = htmlView indexView
let getHttpFromOperation operation (a,b) =
  ExecuteBasicOperation operation a b |> text

let router = router {
  get "/" defaultPage
  not_found_handler (redirectTo false "/")
  get "/json" (json {| Message="Hello World"; Language="F#" |})
  getf "/mul/%i/%i" (getHttpFromOperation Multiplication)
  getf "/add/%i/%i" (getHttpFromOperation Addition)
}

let app = application {
    use_router router
}

run app

//Tests:
//http://localhost:5000/add/2/3 => 5
//http://localhost:5000/mul/2/3 => 6
//http://localhost:5000/json => {"language":"F#","message":"Hello World"}
//http://localhost:5000/anyRoute => htmled I |> F# Hello World
