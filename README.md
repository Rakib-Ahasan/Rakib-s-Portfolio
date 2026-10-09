# Md. Rakib Ahasan — Portfolio

Personal portfolio built with Astro + Tailwind CSS. Static site deployed to GitHub Pages.

## Stack
- Astro (static output)
- Tailwind CSS
- TypeScript
- Content: JSON-driven (src/data/portfolio.json)

## Local development
npm install
npm run dev

## Build
npm run build

## Editing content
All content lives in src/data/portfolio.json.

- profile — name, title, contact, cv, photo
- metrics — key impact numbers
- experience — work history (array)
- projects — project cards (array) with media, coverImage, imageType
- skills — grouped categories
- articles — dev.to links (array)
- education, certifications, contact

## Adding a project
Append to "projects" with: slug, title, status, problem, approach, result, role, tech, media, coverImage, imageType.

## Adding an article
Append to "articles" with: title, url, summary, publishedAt.

## Media
- Profile photo: public/media/profile.jpg
- CV: public/cv.pdf
- Project screenshots: public/media/projects/<slug>/
- Architecture diagrams: public/media/projects/<slug>/diagram.png

## Deploy
Auto-deploys to GitHub Pages on push to main via .github/workflows/deploy.yml.

Live: https://rakib-ahasan.github.io/Rakib-s-Portfolio/