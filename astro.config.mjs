import { defineConfig } from 'astro/config';
import tailwind from '@astrojs/tailwind';

// Project-page deploy: https://rakib-ahasan.github.io/RakibPortfolio/
// For a custom domain, set `site` to the domain and `base` to '/'.
export default defineConfig({
  site: 'https://rakib-ahasan.github.io',
  base: '/RakibPortfolio',
  output: 'static',
  integrations: [tailwind()],
});
