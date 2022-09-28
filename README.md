# Qué hay configurado en esta plantilla

1. Un proyecto de biblioteca (creado con [`dotnet new classlib --name Library`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `src\Library`
2. Un proyecto de aplicación de consola (creado con [`dotnet new console --name Program`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `src\Program`
3. Un proyecto de prueba en [NUnit](https://nunit.org/) (creado con [`dotnet new nunit --name LibraryTests`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `test\LibraryTests`
4. Un proyecto de [Doxygen](https://www.doxygen.nl/index.html) para generación de sitio web de documentación en la carpeta `docs`
5. Análisis estático con [Roslyn analyzers](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview) en los proyectos de biblioteca y de aplicación
6. Análisis de estilo con [StyleCop](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/README.md) en los proyectos de biblioteca y de aplicación
7. Una solución `ProjectTemplate.sln` que referencia todos los proyectos de C# y facilita la compilación con [`dotnet build`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build).
8. Tareas preconfiguradas para compilar y ejecutar los proyectos, ejecutar las pruebas, y generar documentación desde VSCode en la carpeta `.vscode`
9. Análisis de cobertura de los casos de prueba mediante []() que aparece en los márgenes con el complemento de VS Code [Coverage Gutters](https://marketplace.visualstudio.com/items?itemName=ryanluker.vscode-coverage-gutters).
10. Ejecución automática de compilación y prueba mediante [GitHub Actions](https://docs.github.com/en/actions) configuradas en el repositorio al hacer [push](https://github.com/git-guides/git-push) o [pull request](https://docs.github.com/en/github/collaborating-with-pull-requests).

Vean este 🎥 [video](https://web.microsoftstream.com/video/55c6a06c-07dc-4f95-a96d-768f198c9044) que explica el funcionamiento de la plantilla.

## Convenciones

[Convenciones de código en C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

[Convenciones de nombres en C#](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

## Dónde encontrar información sobre los errores/avisos al compilar

[C# Compiler Errors (CS*)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/)

[Roslyn Analyzer Warnings (CA*)](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/categories)

[StyleCop Analyzer Warnings (SA*)](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/DOCUMENTATION.md)

# Cómo deshabilitar temporalmente los avisos al compilar

## Roslyn Analyzer

Comentar las siguientes líneas en los archivos de proyecto (`*.csproj`)
```
    <EnableNETAnalyzers>true</EnableNETAnalyzers>
    <AnalysisMode>AllEnabledByDefault</AnalysisMode>
    <EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>
```

## StyleCop Analyzer

Comentar la línea `<PackageReference Include="StyleCop.Analyzers" Version="1.1.118"/>` en los archivos de proyecto (`*.csproj`)

Universidad Católica del Uruguay


Facultad de Ingeniería y Tecnologías
Programación II
Proyecto 2022 - Segundo Semestre - Chatbot Objetivos de Desarrollo Sostenible - Objetivo 8: Trabajo decente y crecimiento económico
Introducción
En esta edición del curso los estudiantes han propuesto varios proyectos relacionados con los objetivos de desarrollo sostenible de las Naciones Unidas y han elegido uno relacionado con el objetivo 8: Trabajo decente y crecimiento económico. La consigna inicial para la formulación y selección de los proyectos quedó aquí.

Ese objetivo 8 plantea:

Promover el credimiento económico inclusivo y sostenible, el empleo y el trabajo decente para todos [fuente].

La pregunta disparadora del proyecto elegido por los estudiantes es la siguiente:

¿Cómo podemos nosotros, estudiantes del curso de Programación II ayudar a las personas a encontrar trabajo? En base a las necesidades del usuario que el chat bot le responda con datos de quienes otorgan ese servicio. Ejemplo jardineros, pintores, chapistas y otros servicios. Conectando quienes necesitan un servicio y quienes lo ofrecen. Crear dentro del chat bot algo similar a reputación, es decir un jardinero que hizo 3 trabajos ya tiene su clasificación para darle más seguridad a quien lo contrata. También podrían incorporarse sistemas de pagos a través de la "aplicación" lo cual generaría una mayor solides de la estructura previniendo estafas y hurtos.

Acerca de los chatbots
Un chatbot (o bot conversacional) es «un programa que simula mantener una conversación con una persona al proveer respuestas automáticas a entradas hechas por el usuario.»1

Existen gran variedad de chatbots actualmente y varios sabores. Hay chatbots que simplemente responden a comandos pre-establecidos, y otros que integran algoritmos de inteligencia artificial para procesar los mensajes de los usuarios e interpretar lo que se está diciendo.

Algunas de las aplicaciones más conocidas que abren sus puertas al desarrollo de chatbots (tienen APIs) son: Telegram, Messenger, Whatsapp, Slack, Discord, entre otras.

Escenarios
Aquí veremos una explicación general e informal de las funciones del software (nuestro programa), escrita desde la perspectiva del usuario final. Su propósito es articular cómo el software proporcionará una función de valor al cliente.

-Cómo administrador, quiero poder indicar categorías sobre las cuales se realizarán las ofertas de servicios para que de esa forma, los trabajadoras puedan clasificarlos.

-Como administrador, quiero poder dar de baja ofertas de servicios, avisando al oferente para que de esa forma, pueda evitar ofertas inadecuadas.

-Como empleador, quiero registrarme en la plataforma, indicando mis datos personales e información de contacto para que de esa forma, pueda proveer información de contacto a los trabajadores que quiero contratar.

-Como empleador, quiero buscar ofertas de trabajo, opcionalmente filtrando por categoría para que de esa forma, pueda contratar un servicio.

-Como empleador, quiero ver el resultado de las búsquedas de ofertas de trabajo ordenado en forma ascendente de distancia a mi ubicación, es decir, las más cercanas primero para que de esa forma, pueda poder contratar un servicio.

-Como empleador, quiero ver el resultado de las búsquedas de ofertas de trabajo ordenado en forma descendente por reputación, es decir, las de mejor reputación primero para que de esa forma, pueda contratar un servicio.

-Como empleador, quiero poder contactar a un trabajador para que de esa forma pueda, contratar una oferta de servicios determinada.

-Como empleador, quiero poder calificar a un trabajador; el trabajador me tiene que calificar a mi también, si no me califica en un mes, la calificación será neutral, para que de esa forma, pueda definir la reputación del trabajador.

-Como trabajador, quiero poder calificar a un empleador; el empleador me tiene que calificar a mi también, si no me califica en un mes, la calificación será neutral, para que de esa forma pueda definir la reputación de mi empleador.

-Como trabajador, quiero poder saber la reputación de un empleador que me contacte para que de esa forma, poder decidir sobre su solicitud de contratación.

-Como trabajador, quiero registrarme en la plataforma, indicando mis datos personales e información de contacto para que de esa forma, pueda proveer información de contacto a quienes quieran contratar mis servicios.

-Como trabajador, quiero poder hacer ofertas de servicios; mi oferta indicará en qué categoría quiero publicar, tendrá una descripción del servicio ofertado, y un precio para que de esa forma, mis ofertas sean ofrecidas a quienes quieren contratar servicios.


Roadmap y entregables
Instancia	Fecha	Entregables
Kick-off	12 de Setiembre	
Primer Entrega	28 de Setiembre	Entrega de tarjetas CRC/Diagrama de Clases/Código de clases de dominio
Segunda Entrega	30 de Octubre	Entrega de User Stories implementadas. Las historias de usuario deberán ser implementadas mediante casos de prueba (TDD).
Entrega Final	30 de Noviembre	
⚠️ Importante ⚠️
Cada equipo designará qué integrante del equipo desarrollará cada clase. La distribución debe contemplar número de clases y responsabilidades. Se evaluará que cada integrante trabaje en una rama independiente y que se integren los cambios mediante pull requests.

Las entregas serán hasta las :clock: 23:59 del día indicado.
