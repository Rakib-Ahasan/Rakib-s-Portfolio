# Rakib Ahasan's Portfolio

A production-grade personal portfolio website for a senior .NET engineer, built with Blazor WebAssembly (.NET 10 LTS) and Tailwind CSS via CDN. The site is fully static, driven by a JSON data source (`wwwroot/data/portfolio.json`), and designed for deployment to Azure Static Web Apps or GitHub Pages.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- A modern web browser

## How to Run Locally

1. Clone the repository.
2. Navigate to the project root (`D:\RakibPortfolio`).
3. Run:
   ```bash
   dotnet run
   ```
4. Open your browser to `http://localhost:5000` (or the URL shown in the terminal).

## How to Edit Content

All text content comes from `wwwroot/data/portfolio.json`. Edit this file to update your portfolio.

### Section-by-Section Guide

- **Profile**: Update your name, title, location, contact details, and pitch.
- **Summary**: Edit the professional summary string.
- **KeyResults**: Add or remove strings in the array (each appears as a stat chip).
- **Experience**: Add, remove, or modify objects in the `experience` array. Each object requires:
  - `role`, `company`, `duration`, `location`, `context`, and `bullets` (array of strings).
- **Skills**: Update the 7 categories (Backend, Frontend, Architecture, Databases & Caching, Cloud & DevOps, Security & Payments, Testing & Practices) by modifying the arrays of strings.
- **Projects**: Add, remove, or modify objects in the `projects` array. Each object requires:
  - `name`, `status` (e.g., "Delivered", "In Progress"), `tech` (array of strings), `problem`, `solution`, and `outcome`.
- **Writing**: An array of article objects (each with `title`, `url`, and optional `summary`). Leave empty to show the empty state.
- **Contact**: Update your email, LinkedIn, GitHub, phone, and set your Formspree endpoint (get one from [Formspree](https://formspree.io/)).
- **Education**: Update your degree, institution, CGPA, and years.
- **Certifications**: Add or remove strings in the array.

### How to Add a New Experience Entry

Add an object to the `"experience"` array in `portfolio.json`, following this example:

```json
{
  "role": "Senior Software Engineer",
  "company": "New Company Ltd.",
  "duration": "Jan 2027 - Present",
  "location": "Remote",
  "context": "Leading a team to build cloud-native applications.",
  "bullets": [
    "Led development of a microservices platform handling 10K RPM.",
    "Reduced infrastructure costs by 40% through Kubernetes optimization.",
    "Mentored 5 junior engineers in .NET and Azure best practices."
  ]
}
```

### How to Add a New Project

Add an object to the `"projects"` array, following this example:

```json
{
  "name": "New Project Name",
  "status": "Delivered",
  "tech": ["Blazor", ".NET 8", "Azure SQL"],
  "problem": "Clients needed a real-time dashboard for sales data.",
  "solution": "Built a Blazor WebAssembly app with SignalR for live updates.",
  "outcome": "Dashboard adopted by 3 regional offices, improving decision-making speed."
}
```

### How to Add a New dev.to Article

Add an object to the `"articles"` array (leave empty for now; fill later):

```json
{
  "title": "My First dev.to Article",
  "url": "https://dev.to/rakib-ahasan/my-first-article-1234",
  "summary": "A brief summary of the article (optional).",
  "publishedAt": "2024-01-15"
}
```

### How to Change the Accent Color

The accent color is defined as a CSS variable in `wwwroot/css/app.css`:

1. Open `wwwroot/css/app.css`.
2. Find the `:root[data-theme="dark"]` and `:root[data-theme="light"]` sections.
3. Change the value of `--accent` (currently `#06b6d4`) to your desired color.
4. The change will apply site-wide (buttons, links, icons, etc.).

### How to Change the Theme Default

The theme (dark/light) is stored in `localStorage` under the key `theme`. The site initializes by reading this key; if not present, it defaults to `dark`.

To change the default:
- Open `wwwroot/index.html`.
- In the theme initialization script (look for `const theme = localStorage.getItem('theme') || 'dark';`), change `'dark'` to `'light'` if you want light mode as the default.

Alternatively, you can manually set it in the browser's console:
```javascript
localStorage.setItem('theme', 'light');
location.reload();
```

## Deploy to Azure Static Web Apps (Primary)

1. **Prerequisites**:
   - Azure account
   - Azure CLI installed (`az`)
   - GitHub repository pushed to GitHub

2. **Steps**:
   ```bash
   # Login to Azure
   az login

   # Create a resource group (if you don't have one)
   az group create --name rakib-portfolio-rg --location eastus

   # Create the Static Web App
   az staticwebapp create \
     --name rakib-portfolio \
     --resource-group rakib-portfolio-rg \
     --location eastus \
     --source "https://github.com/<YOUR-GITHUB-USERNAME>/RakibPortfolio" \
     --branch main \
     --app-location "/" \
     --output-location "wwwroot" \
     --sku Free
   ```
   Replace `<YOUR-GITHUB-USERNAME>` with your GitHub username or organization.

   After creation, Azure will provide a URL (e.g., `https://rakib-portfolio.azurestaticapps.net`).

3. **Updates**:
   Push to the `main` branch; Azure Static Web Apps will automatically rebuild and redeploy.

## Deploy to GitHub Pages (Alternative)

1. **Adjust `wwwroot/index.html`**:
   - Set the `<base>` tag to your GitHub Pages URL (e.g., if your repo is `rakib-ahasan.github.io`, use `<base href="/">`; if it's under a project repo like `rakib-ahasan.github.io/portfolio`, use `<base href="/portfolio/">`).

2. **Publish**:
   - Use the `dotnet publish` command to generate the static files:
     ```bash
     dotnet publish -c Release -o publish
     ```
   - The contents of the `publish/wwwroot` folder are what you need to deploy.

3. **Deploy via GitHub Actions** (see the workflow below) or manually push to the `gh-pages` branch.

   For manual deployment:
   ```bash
   # Assuming you have the published files in publish/wwwroot
   cd publish/wwwroot
   git init
   git checkout -b gh-pages
   git add .
   git commit -m "Initial gh-pages commit"
   git remote add origin https://github.com/<YOUR-GITHUB-USERNAME>/RakibPortfolio.git
   git push -f origin gh-pages
   ```

   Then enable GitHub Pages in the repository settings, selecting the `gh-pages` branch.

## How to Add a Custom Domain

### For Azure Static Web Apps
1. In the Azure Portal, go to your Static Web App resource.
2. Under "Custom domains", click "Add".
3. Follow the instructions to verify domain ownership (typically by adding a TXT or CNAME record).
4. Once verified, your custom domain will be active.

### For GitHub Pages
1. In your repository settings under "Pages", click "Add a domain".
2. Enter your custom domain (e.g., `www.rakib-ahasan.com`).
3. Follow the instructions to configure your DNS (usually an `A` record pointing to GitHub's IP addresses or a `CNAME` for `username.github.io`).
4. Wait for DNS propagation, then your site will be available at the custom domain.

## Troubleshooting

- **Build fails with CS1061 (missing property)**: Ensure your `portfolio.json` matches the model classes (especially after adding new properties like `Summary` to `Article`). Run `dotnet build` to see errors.
- **Loading stuck on "Loading..."**: Check the browser console (F12) for errors loading `portfolio.json`. Verify the file exists and is valid JSON.
- **Theme not toggling**: Ensure the `ThemeService` is registered in `Program.cs` and the `IThemeService` is injected where used.
- **Styles not updating**: Tailwind via CDN may cache; hard-refresh (Ctrl+F5) or clear cache.
- **Deployment fails**: Verify your Azure Static Web Apps token (secret) is set correctly in the GitHub workflow or Azure portal.

## Tech Stack

- **Framework**: Blazor WebAssembly (.NET 10 LTS)
- **Styling**: Tailwind CSS via CDN (no build step)
- **Data**: Static JSON (`wwwroot/data/portfolio.json`)
- **Icons**: Bootstrap Icons (via Bootstrap CSS)
- **Fonts**: Inter (body) and JetBrains Mono (code/numbers) from Google Fonts
- **Deployment**: Azure Static Web Apps (primary), GitHub Pages (alternative)
- **Form Handling**: Formspree (for the contact form)
- **Version Control**: Git + GitHub

## License

This project is for personal use. Feel free to adapt it for your own portfolio, but please do not use it to misrepresent your experience.

---
*Built with ❤️ by Md. Rakib Ahasan*