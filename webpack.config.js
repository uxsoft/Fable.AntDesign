var path = require("path");

module.exports = {
    entry: "./src/Fable.AntDesign.Examples/dist/App.js",
    output: {
        path: path.join(__dirname, "./src/Fable.AntDesign.Examples/public"),
        filename: "bundle.js",
    },
    devServer: {
        static: {
            directory: "./src/Fable.AntDesign.Examples/public",
        },
        port: 8080,
        hot: true,
    }
}