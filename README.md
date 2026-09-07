# Desarrollo de una Web API con ASP.NET Core

Estás encargado de desarrollar una Web API para gestionar productos en un catálogo de e-commerce. La API debe permitir la creación, lectura, actualización y eliminación de productos. Los productos tienen atributos como nombre, precio, stock y categoría. Debes asegurar que los precios no sean negativos y que los nombres no estén duplicados. La API debe ser idempotente y manejar correctamente los errores de validación.

## Informacion General

| Campo | Valor |
|-------|-------|
| **Tema** | C# ASP.NET Core |
| **Nivel** | junior-l2 |
| **Tipo** | practical |
| **Tiempo estimado** | 8 horas |

## Fases del Reto

### Fase 0: Configuración del Proyecto

**Objetivo:** Obtener el proyecto base funcional enviando el Código Base a un asistente de IA, que lo analizará, corregirá errores y generará un ZIP listo para usar.

**Tiempo estimado:** 15-30 minutos

**Instrucciones:**

- Asegúrate de tener instalado para ejecutar el proyecto: Un IDE o editor de código.
- Copia todo el contenido del campo **Código Base** de este reto — incluyendo el texto de instrucciones que aparece al inicio.
- Abre un asistente de IA (Claude en claude.ai, ChatGPT o Gemini — se recomienda Claude), pega el contenido copiado en el chat y envíalo.
- El asistente analizará los archivos, corregirá errores y generará un archivo ZIP descargable. Descárgalo y extráelo en la carpeta donde quieras trabajar.
- Verifica que el proyecto arranca sin errores.

**Entregable:** El proyecto compila/arranca sin errores.

<details>
<summary>Pistas de conocimiento</summary>

- Copia el Código Base completo incluyendo el texto de instrucciones al inicio — esas instrucciones le indican al asistente exactamente qué hacer con los archivos.
- Si el asistente no genera el ZIP automáticamente al terminar el análisis, escríbele: "genera el ZIP ahora".
- Si el proyecto tiene errores al arrancar, comparte el mensaje de error con el mismo asistente para que lo corrija.

</details>

### Fase 1: Configuración del proyecto

**Objetivo:** Configurar un proyecto de ASP.NET Core con Entity Framework y Swagger.

**Tiempo estimado:** 2 horas

**Instrucciones:**

- Configurar el proyecto de ASP.NET Core.
- Agregar Entity Framework para el acceso a datos.
- Configurar Swagger para la documentación de la API.

**Entregable:** Proyecto de ASP.NET Core configurado con Entity Framework y Swagger.

<details>
<summary>Pistas de conocimiento</summary>

- Revisa la documentación de ASP.NET Core para la configuración inicial.
- Consulta la documentación de Entity Framework para la integración con ASP.NET Core.
- Lee la documentación de Swagger para configurar la documentación de la API.

</details>

### Fase 2: Implementación de endpoints CRUD

**Objetivo:** Implementar los endpoints CRUD para la gestión de productos.

**Tiempo estimado:** 4 horas

**Instrucciones:**

- Crear los endpoints para la creación, lectura, actualización y eliminación de productos.
- Asegurar que los precios no sean negativos y que los nombres no estén duplicados.
- Implementar la idempotencia en los endpoints.

**Entregable:** Endpoints CRUD implementados y funcionales para la gestión de productos.

<details>
<summary>Pistas de conocimiento</summary>

- Revisa los métodos HTTP para cada operación CRUD.
- Consulta la documentación de Entity Framework para la manipulación de datos.
- Investiga sobre idempotencia y cómo implementarla en tus endpoints.

</details>

### Fase 3: Manejo de errores y documentación

**Objetivo:** Implementar el manejo de errores y documentar la API con Swagger.

**Tiempo estimado:** 2 horas

**Instrucciones:**

- Implementar el manejo de errores en los endpoints.
- Documentar la API utilizando Swagger.
- Asegurar que la documentación sea clara y completa.

**Entregable:** API con manejo de errores y documentación completa en Swagger.

<details>
<summary>Pistas de conocimiento</summary>

- Revisa las mejores prácticas para el manejo de errores en ASP.NET Core.
- Consulta la documentación de Swagger para asegurarte de que la documentación sea completa y clara.

</details>

## Dimensiones Evaluadas

- **queEs**: ¿Qué es ASP.NET Core y por qué se usa para desarrollar Web APIs?
- **paraQueSirve**: ¿Para qué sirve Entity Framework en el desarrollo de una Web API con ASP.NET Core?
- **comoSeUsa**: ¿Cómo se usa Swagger para documentar una Web API?
- **erroresComunes**: ¿Cuáles son los errores comunes al implementar endpoints CRUD y cómo se pueden evitar?
- **queDecisionesImplica**: ¿Qué decisiones implica la implementación de la idempotencia en los endpoints de una Web API?

## Criterios de Evaluacion

- Configurar correctamente un proyecto de ASP.NET Core con Entity Framework y Swagger.
- Implementar endpoints CRUD funcionales con validaciones y idempotencia.
- Manejar correctamente los errores y documentar la API con Swagger.

## Como trabajar con un asistente de IA

- **AGENTS.md** — instrucciones nativas del repo (Cursor, Codex, Copilot, Gemini, Claude Code). Abrí el proyecto y el agente las carga solo.
- **PROMPT_MEJORA.md** — el mismo prompt, para copiar y pegar en un chat (claude.ai, ChatGPT, etc.).

---

*Reto generado automaticamente por Challenge Generator - Pragma*
