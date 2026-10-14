# Md. Rakib Ahasan — Portfolio

Astro + Tailwind CSS portfolio for a .NET backend engineer, deployed as a static site to GitHub Pages.

Live site: https://rakib-ahasan.github.io/Rakib-s-Portfolio/

## Stack

- Astro 4
- Tailwind CSS 3
- TypeScript
- Inter and JetBrains Mono
- JSON-driven content

## Run locally

```bash
npm install
npm run dev
npm run build
npm run preview
```

## Project structure

- `src/components/` — page sections and UI components
- `src/data/portfolio.json` — portfolio content
- `src/layouts/` — document shell and metadata
- `src/styles/` — global theme and responsive styles
- `public/` — static assets such as the CV, favicon, and profile photo

## Editing content

Edit `src/data/portfolio.json` to update:

- `profile`, including contact details and optional booking URL
- `experience` and `skills`
- `projects`, including optional `role`, `flow`, `metrics`, `decisions`, and `improvements`
- `articles` for the optional Writing section
- `education`, `certifications`, and contact settings

Empty optional fields render no UI.

## Deployment

The workflow in `.github/workflows/deploy.yml` builds the Astro site with `withastro/action@v3` on pushes to `main`, then deploys the result with `actions/deploy-pages@v4` to GitHub Pages.