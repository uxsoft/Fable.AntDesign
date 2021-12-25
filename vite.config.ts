import { defineConfig } from "vite"

export default defineConfig({
    root: "./src/Fable.AntDesign.Examples",
    build: {
        outDir: "./dist",
        emptyOutDir: true,
        sourcemap: true,
    },
    server: {
        proxy: {
            "/api": {
                target: "http://localhost:7071",
                changeOrigin: true,
                secure: false,
                ws: true,
            }
        }
    },
});