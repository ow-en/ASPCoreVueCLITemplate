# Vue-cli & ASP.NET Core 2.1 with Vue.js + TypeScript and Vuetify

## To Install `dotnet new` template:

- clone repository
- within CLI, run `dotnet new -i <path to repository folder where .template.config is located>`
- to confirm template was installed, run `dotnet new -l`
- to scaffold a new project using this template, run `dotnet new VueCLINetCoreEFCore -n <nameofproject> -o <nameofproject>`

## To Install/Run Repository:

- clone repo and run `dotnet restore`
- install VUE-CLI `npm i -g @vue/cli`
- open a CLI, in any directory, and type `vue ui`
- within the vue-cli GUI, create a new project.
- within the project navigation wizard, navigate to the `VueCLICore` directory of this project (the presentation layer)
- within the `VueCLICore` directory, choose vue-cli's output directory as `ClientApp` **important: make sure "overwrite existing folder" option is checked**
- when creating the project, vue-cli GUI will allow you to use a preset, or to manually configure the project setup (and/or create a new preset). Choose manual config.
- when going through the manual configuration, select everything you want to include in the project. I recommend selecting most of the options, with Mocha for unit testing (VS compatible) and Nightwatch for e2e testing (VS & Selenium compatible)
- if you are planning on installing the Vuetify plugin after project creation, make sure that you select Stylus as the CSS preprocessor option during project setup.
- if selecting TypeScript as an option during project creation, make sure that your linting option is set to TSLint.
- create the project. when vue-cli GUI is done scaffolding the new project (inside `ClientApp`), navigate to the `ClientApp` directory and `npm install`
- At this point, you can do one of two things: add plugins (such as Vuetify) through vue-cli GUI `plugins` section, or you can run the project as-is through IIS or CLI (see below) **if adding Vuetify, I recommend allowing vue-cli to scaffold the Vuetify dependencies _before_ running the project**
- run the project through IIS in Visual Studio or through CLI using `npm run serve` (navigate to port 8080)

**Important note regarding HMR in IIS: make sure to disable SSL in the `Properties` section of the root project in Visual Studio.**
