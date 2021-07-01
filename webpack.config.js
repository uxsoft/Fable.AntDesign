// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

var path = require("path");

module.exports = {
    entry: "./src/Fable.AntDesign.Examples/dist/App.js",
    output: {
        path: path.join(__dirname, "./src/Fable.AntDesign.Examples/public"),
        filename: "bundle.js",
    },
    devServer: {
        contentBase: "./src/Fable.AntDesign.Examples/public",
        port: 8080,
        hot: true,
        inline: true
    },
    module: {
        rules: [
            {
                test: /\.css$/i,
                use: ["style-loader", "css-loader"]
            }
        ]
    }
}