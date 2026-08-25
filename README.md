# Cycling Peak

Cycling Peak is a web and mobile application for cyclists. The product combines ride recording and analysis, bike management, route planning, progress goals, and social features in a single experience.

## Objective

The MVP validates the product’s core cycle:

**Account → Bike → Ride → Statistics → Goal → Progress**

The first version focuses on the product foundation without attempting to immediately cover every feature offered by mature platforms such as Strava, Komoot, or Garmin Connect.

## Planned Features

- accounts and authentication;
- bike and maintenance management;
- ride recording and history;
- basic statistics and performance analysis;
- goals, progress, and achievements;
- route planning and exploration;
- social feed, clubs, and group rides;
- segments and challenges;
- integration with sensors, Garmin, and health platforms;
- advanced analytics and AI Cycling Coach;
- light and dark themes;
- a language selector for switching between Romanian and English.

## Platforms and Experience

The application is designed for web and mobile. The mobile version uses the same Angular codebase, packaged with Capacitor 8 for iOS and Android.

## Tech Stack

### Frontend

- Angular 22
- PrimeNG
- Capacitor 8
- Vitest

### Backend

- .NET 10 (ASP.NET Core Web API)
- Entity Framework Core
- SQL Server
- xUnit

### Testing and Cloud

- Playwright for end-to-end scenarios;
- Azure for cloud infrastructure and services;
- Azure SQL for the cloud database.

## Architecture

The backend is initially planned as a modular monolith. The Angular frontend uses standalone components, signals, lazy-loaded routes, and typed reactive forms. Capacitor provides access to native functionality without a separate mobile codebase.

## Documentation

The product documentation includes:

- Product Brief — product vision, users, and direction;
- PRD — functional requirements, architecture, and acceptance criteria;
- MVP Specification — scope and priorities for the first version;
- V1–V4 documentation — social & routes, segments/challenges/clubs, sensors and Garmin/Health integrations, advanced analytics, and AI Coach.

## MVP Principles

- incremental delivery;
- a consistent web and mobile experience;
- a single frontend codebase;
- clear, easily extensible features;
- explicit separation of post-MVP functionality.
