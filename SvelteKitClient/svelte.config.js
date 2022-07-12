import preprocess from "svelte-preprocess";
import adapter from "@sveltejs/adapter-static";

/** @type {import('@sveltejs/kit').Config} */
const config = {
  kit: {
    adapter: adapter({
      fallback: 'index.html',
      pages: '..\\DotNetAPI\\DotNetAPI\\wwwroot',
      assets: '..\\DotNetAPI\\DotNetAPI\\wwwroot',
    }),
  },

  preprocess: [
    preprocess({
      postcss: true,
    }),
  ],
};

export default config;