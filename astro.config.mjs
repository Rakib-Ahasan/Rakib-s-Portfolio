import { defineConfig } from 'astro/config';
import tailwind from '@astrojs/tailwind';

export default defineConfig({
  integrations: [tailwind()],
  site: 'https://rakib-ahasan.dev',
  base: '/',
  output: 'static',
  trailingSlash: 'always',
});