# Planificador de Actividades con Cortes de Luz

## Descripción

Este proyecto es un **Planificador de Actividades con Cortes de Luz**, diseñado para ayudar a las personas a organizar sus tareas semanales teniendo en cuenta los horarios de apagones programados. El sistema prioriza tareas que requieren electricidad, genera un plan semanal automatizado y permite ajustarlo manualmente.

## Funcionalidades Principales

- **Horarios de Corte**:
  - Registrar horarios de cortes de luz programados.
- **Gestión de Actividades**:
  - Registrar actividades, clasificándolas según si requieren electricidad y su duración.
- **Planificador Semanal**:
  - Generar un plan semanal automático con las actividades organizadas en horarios con luz disponible.
  - Ajustar el plan manualmente si es necesario.
- **Recordatorios**:
  - Enviar notificaciones o correos recordando actividades próximas.
- **Exportación del Plan**:
  - Descargar el plan en formato PDF o como vista imprimible.

## Tecnologías Utilizadas

- **Backend**: ASP.NET Core
- **Frontend**: Razor Pages
- **Base de Datos**: SQL Server
- **ORM**: Entity Framework Core

## Requisitos Previos

1. **Visual Studio 2022** o superior con el workload de **ASP.NET y desarrollo web**.
2. **SQL Server** instalado y configurado.
3. **.NET Core SDK** versión 6.0 o superior.

## Configuración del Proyecto

### 1. Clonar el Repositorio

```bash
git clone https://github.com/tu-usuario/planificador-actividades.git
cd planificador-actividades
