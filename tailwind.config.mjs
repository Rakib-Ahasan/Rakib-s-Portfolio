/** @type {import('tailwindcss').Config} */
export default {
  darkMode: 'class',
  content: ['./src/**/*.{astro,html,js,jsx,md,mdx,svelte,ts,tsx,vue}'],
  theme: {
    extend: {
      colors: {
        accent: {
          DEFAULT: '#1F4E79',
          50: '#f1f6fb',
          100: '#e2edf6',
          200: '#bcd4e9',
          300: '#8fb4d6',
          400: '#5b8fbd',
          500: '#3a6fa0',
          600: '#1F4E79',
          700: '#1a4267',
          800: '#163450',
          900: '#132b41',
        },
      },
      fontFamily: {
        sans: ['Inter', 'system-ui', '-apple-system', 'Segoe UI', 'Roboto', 'sans-serif'],
        mono: ['ui-monospace', 'SFMono-Regular', 'Menlo', 'Consolas', 'monospace'],
      },
      maxWidth: {
        content: '1000px',
      },
    },
  },
  plugins: [],
};
