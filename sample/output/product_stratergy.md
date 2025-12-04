# Product vision and positioning

Vision  
Build a fast, privacy-first calorie and nutrition tracker that makes accurate logging effortless (photo + smart templates), delivers actionable, personalized guidance for weight and health goals, and supports clinician/coaching workflows — all while giving users full control over their data.

How it fits into the current product/portfolio  
This feature becomes the core consumer-facing product in a broader digital nutrition & wellbeing portfolio. It sits alongside (or integrates with) activity tracking, sleep analytics, and coaching tools: the nutrition tracker supplies high-quality intake data to drive personalization and clinician insights, and feeds downstream premium experiences (personalized plans, coaching dashboard, enterprise offerings).

Primary value proposition (1–2 sentences)  
Save users time and increase accuracy: let them log meals in seconds using photo recognition, smart portioning, and reusable meal templates — while providing clinically useful, shareable insights and preserving user privacy so they can trust the product with sensitive health data.

Note: This strategy builds on the Research Agent’s findings (users’ pain points, competitive gaps, suggested PRD). Market search returned no results during research, so some external-market assumptions are called out below.

# Goals

Goal 1 — Reduce logging friction and increase consistent logging  
- Make meal logging fast (median time per meal < 10 seconds for serialized quick-logging flows) and increase weekly logging frequency such that at least 40% of active users log meals on 5+ days/week within 90 days.

Goal 2 — Deliver reliably accurate intake estimates and clinically useful outputs  
- Reach a photo-assisted calorie estimate accuracy baseline (median absolute error) of within 20–25% on common meals for MVP, and provide shareable clinician reports (CSV/PDF) that satisfy basic clinician needs for client monitoring.

Goal 3 — Achieve early retention and monetization benchmarks  
- Achieve 30-day retention ≥ 20% and a premium conversion (freemium → paid) of 3–5% within the first 6 months for initial markets.

Goal 4 — Position the product as privacy-first and trustworthy  
- Ensure >90% of sensitive image processing requests are processed on-device (or by explicit opt-in cloud processing), and provide transparent, granular privacy controls and disclosures at onboarding.

Goal 5 — Validate clinician/coaching demand and enterprise potential  
- Pilot with 10–20 dietitians/coaches and onboard at least 200 client accounts into the coach dashboard in a paid/paid-pilot model within 6–9 months.

# Non-goals

Non-goal 1 — Not a regulated medical device at MVP  
- The initial product will not provide diagnostic claims or regulated medical decisioning; any regulated functionality will be explicitly planned and treated as a separate roadmap item.

Non-goal 2 — Not a full replacement for dietitian care  
- The product will provide data and behavior-support features, not clinical diagnosis, medication advice, or therapy.

Non-goal 3 — Not global/localized at launch  
- Launch initially in the US / English markets; full localization and region-specific food data will be a post-MVP roadmap item.

Non-goal 4 — Not all nutrients or niche diets in MVP  
- MVP focuses on calories, macros, and selected micros (e.g., sodium, fiber, carbs); exhaustive nutrient lists and specialized diet modules (FODMAP, low-histamine) are out of scope for initial release.

Non-goal 5 — Not a social-first product at launch  
- Social feed / community features are not prioritized in MVP; focus is logging, insights, and coach integrations.

# Success metrics

Metric 1 — Activation / Onboard completion rate  
- Definition: % of new users who complete onboarding (create profile, set a goal, and log at least one meal) within 7 days. Target: ≥ 50% in month 1, improving to ≥ 60% by month 3.

Metric 2 — Time-to-log (primary UX metric)  
- Definition: Median seconds from open-to-log-complete for a meal using the fastest available flow (photo-assisted or quick templates). Target: median ≤ 10 seconds for the quick flow; 90th percentile ≤ 30 seconds.

Metric 3 — Logging consistency (engagement)  
- Definition: % of active users who log meals on ≥5 distinct days in a 7-day week (measured weekly). Target: ≥ 40% of active users within 90 days.

Metric 4 — Retention (user retention)  
- Definition: 30-day retention rate (users who return and perform a logging action within 30 days). Target: ≥ 20% for initial cohort.

Metric 5 — Photo recognition accuracy (product quality)  
- Definition: % of photo-assisted logs where the calorie estimate is within ±25% of ground-truth measured/calculated calories (measured on validation sets / pilot users). Target: ≥ 70% for common meals in MVP; improve over time.

Metric 6 — Monetization / Conversion  
- Definition: % of active users that convert to paid tier within 90 days. Target: 3–5% initial; aim to increase to 5–8% with product improvements and premium features.

Metric 7 — Clinician adoption (pilot)  
- Definition: # of clinicians/coaches onboarded to pilot / # of client accounts shared with clinicians. Target: 10–20 clinicians and 200+ clients in pilot within 6–9 months.

Metric 8 — Privacy compliance/adoption metric  
- Definition: % of image analyses processed on-device (vs cloud) and % of users who opt into any data-sharing features. Target: ≥ 90% on-device processing by default; explicit opt-in rates for cloud features tracked.

Metric 9 — NPS / Feature satisfaction  
- Definition: NPS or feature-specific satisfaction score for logging experience (sent after 30 days). Target: feature satisfaction ≥ 40 (or NPS > 0) as an early signal.

# Risks and assumptions

- Research gap: live web searches returned no results in the research step; market-statistics and recent competitor changes were assumed from domain knowledge up to mid-2024. Mitigation: re-run web research and collect up-to-date app-store summaries and market reports before roadmap finalization.
- ML performance risk: photo recognition accuracy may vary widely by cuisine, lighting, and mixed dishes. Mitigation: ship photo as assistive (user confirms/edits), prioritize templates and reusable meals, invest in progressive ML improvement and human-in-the-loop curation.
- Data licensing & DB quality: licensing a high-quality food database and maintaining curated entries may be costly and time-consuming. Mitigation: hybrid model (licensed DB for packaged foods + curated + verified user contributions).
- Regulatory risk: adding clinician features may trigger HIPAA/medical device considerations. Mitigation: design clinician features as privacy-conscious exports; treat HIPAA readiness as a separate milestone.
- Monetization / pricing risk: subscription conversion may be lower than forecast if core features are gated. Mitigation: keep essential logging free, test pricing, and iterate value props for premium.

# Updated PRD outline (integrated Research + Strategy)

The Research Agent’s PRD outline is preserved and enhanced here with strategic sections (vision, goals, metrics), prioritized requirements, and operational plans that align to success metrics.

1. Executive Summary  
   - One-paragraph overview.  
   - Product vision (copy from above).  
   - Core value proposition and target user segments.

2. Problem Statement & Opportunity  
   - Restated user problems (logging friction, database accuracy, privacy).  
   - Market opportunity and strategic positioning (privacy-first, photo/ML-enabled logging, clinician-ready).  
   - Risks & assumptions (call out research limitations and key dependencies).

3. Product Vision & Positioning (Strategic Section)  
   - Vision statement and positioning vs incumbents.  
   - Primary differentiators: speed of logging, privacy model, clinician integration.

4. Goals & Success Metrics (KPIs)  
   - List of high-level goals (from Goals section).  
   - Success metrics (defined, with targets and measurement cadence).  
   - Dashboard requirements to track metrics.

5. Target Users & Personas  
   - Emily, Sam, Priya, Alex (brief).  
   - Prioritization: primary vs secondary personas and acceptance criteria.

6. User Journeys & Core Flows (with performance targets)  
   - Onboarding → goal setup → first-log (activation target).  
   - Meal logging flows (photo-assisted flow, barcode flow, search flow, reusable meal templates). Include expected time-to-log targets.  
   - Goal-adjustment flow (adaptive budgets) and progress review.  
   - Clinician share/export flow and coach dashboard flow.  
   - Privacy & permissions flow (on-device defaults, opt-ins).

7. Feature Requirements — MVP & Roadmap (priority mapped to goals)  
   MVP (must-haves aligned to goals):  
   - Fast logging flows: photo-assisted capture, barcode scanner, search, reusable meal templates.  
   - Basic nutrient tracking: calories, macros, carbs, sodium, fiber.  
   - On-device image processing by default; cloud-assisted fallback if user opts in.  
   - User onboarding with goal setup and first-log success path.  
   - Basic integration with Apple Health / Google Fit for activity/weight.  
   - Exportable clinician report (CSV/PDF) and a minimal coach dashboard (pilot-ready).  
   - Privacy controls and transparent policy language.  
   Roadmap (post-MVP):  
   - Improved ML models, cultural cuisine support, recipe parsing, advanced micronutrient tracking, meal timing and satiety signals, habit coaching modules, enterprise features (SAML, admin console).

8. Data & Privacy Model (detailed)  
   - Data collected (images, logs, weights, activity).  
   - On-device vs cloud processing policy and design (default on-device).  
   - Data retention, anonymization, and export rules.  
   - Compliance plan: PII handling, HIPAA readiness threshold and triggers.

9. Integrations & Platform Requirements  
   - Apple Health / Google Fit, Fitbit, Garmin, smart scales.  
   - Food database providers (licensed DBs), barcode data partners.  
   - Auth, SSO, coach integrations, export endpoints (CSV, PDF, API).

10. UX / Design Principles & Accessibility  
   - Low-friction, one-thumb logging; clear defaults; microcopy for privacy; localization plan.  
   - Accessibility checklist and support for diverse cuisines / portion visuals.

11. Technical Architecture Overview & ML Ops  
   - Mobile-first architecture, on-device ML components, sync/back-end, ML training pipeline, data quality processes, model update cadence.  
   - Offline-first logging semantics and sync conflict resolution.

12. Analytics, Experimentation & Data Quality Plan  
   - Events to track (onboard complete, log events, photo corrections), funnels (activation → 7-day retention → 30-day retention).  
   - A/B test candidates (onboarding variants, photo-first vs search-first flows, premium messaging).  
   - Data quality governance for food DB and user-contributed entries.

13. Monetization Strategy & GTM (go-to-market)  
   - Freemium model: core logging free; premium tier for advanced insights, advanced exports, history analytics, coach features.  
   - Pricing experiments and initial pilot pricing for coaches/clinics.  
   - Launch plan: pilot with clinicians and early adopters, referral programs, partnerships (dietitian associations), ASO strategy.

14. Customer Support & Community Signals  
   - Support flows for incorrect database entries, image recognition errors, refund policies.  
   - Feedback loops to feed into DB curation and ML improvements.

15. Compliance, Legal & Security Considerations  
   - Privacy policy, terms of service, security controls, third-party agreements, HIPAA trigger plan.

16. Roadmap & Milestones (phased)  
   - Phase 0 (0–3 months): prototype quick-log flows, basic DB, Apple/Google Fit integration, privacy-first defaults, pilot clinician export.  
   - Phase 1 (3–6 months): photo-assisted logging MVP, on-device ML, retention experiments, initial paid tier.  
   - Phase 2 (6–12 months): Coach dashboard, improved ML/cuisine coverage, enterprise pilots, localization planning.

17. Validation & Research Plan  
   - 5–10 user interviews per persona pre-launch, usability testing of the <10s log flow, clinician pilot validation for exports, accuracy validation sets for ML (labelling and ground truth).  
   - Ongoing product analytics and qualitative feedback cadence.

18. Risks & Mitigations (detailed)  
   - ML accuracy variability, DB licensing costs, regulatory triggers, low conversion. Each with mitigation actions and owners.

19. Financial assumptions & business model details  
   - CAC assumptions per channel (to be validated), LTV projections for different premium conversion scenarios, revenue targets for 12 months.

20. Success Monitoring & Post-launch Iteration Plan  
   - Weekly dashboards for core metrics, monthly product reviews tied to metrics, priority list for feature bets.

Appendices  
- Persona details (full), glossary, sample clinician report, sample privacy UI copy, data schema snapshot.

Notes on prioritization: each MVP item in the Feature Requirements must map to at least one primary metric (e.g., time-to-log, 30-day retention, photo accuracy). Product and engineering teams should build a measurement plan (analytics events, instrumentation) before launch.

---

If you want, next steps I can take (pick one or more):  
- Draft an initial prioritized MVP backlog (user stories + acceptance criteria) mapped to metrics.  
- Draft onboarding and privacy microcopy and consent flow for the default on-device model.  
- Create a concrete pilot plan to recruit 10–20 clinicians and define data/consent agreements.  
- Re-run web research and fetch up-to-date market reports and competitor changes to refine targets and pricing assumptions.
technical_architect_83d6d8d2875b408...
07:09:46
completed
technical_architect_83d6d8d2875b408...
Run #2
07:09:48
completed
Output:
# Technical Feasibility
- Overall feasibility assessment  
  The product is feasible with current technology. Core logging (search, barcode, reusable meals, sync, analytics, Apple Health/Google Fit) is straightforward. Photo-assisted food recognition and portion estimation are feasible but require significant ML investment (on-device models, dataset collection, progressive improvement). Clinician/coach dashboards and exports are standard web features. Privacy-first on-device processing is technically achievable but increases engineering effort (model optimization, native integrations).

- Complexity level  
  Complex — due to ML requirements (on-device inference, accuracy targets), data quality and curation needs, integrations (wearables, health platforms), and potential clinician/HIPAA considerations.

- Key technical challenges  
  1. Achieving reliable photo-assisted calorie/macro estimates across cuisines and mixed dishes while keeping processing on-device (model size, latency, accuracy).  
  2. Portion-size estimation from images (depth/scale ambiguity).  
  3. Building and maintaining a high-quality food database (licensed data + curated user entries + deduplication).  
  4. Privacy/HIPAA readiness if clinician features expand — encryption, audit trails, data residency.  
  5. Offline-first mobile sync with conflict resolution and eventual consistency.  
  6. Packaging models for iOS/Android (Core ML / TensorFlow Lite / ONNX), updating models securely on devices.  
  7. Instrumentation and measurement for product metrics (time-to-log, photo accuracy) with privacy constraints.

# Recommended Technical Approach
- High-level architecture
  - Mobile-first clients (iOS native + Android native OR cross-platform with native ML modules).  
  - Backend services (REST/GraphQL API) responsible for user profiles, food DB sync, logging storage, subscriptions, analytics ingestion, and coach dashboard.  
  - Food Database service: hybrid of licensed master DB + curated user contributions + moderation pipeline.  
  - ML stack: training pipelines (cloud GPU), model registry, and inference runtimes for on-device models.  
  - Sync & offline layer: local DB on device (SQLite/Realm) + background sync service + conflict resolution rules.  
  - Storage: encrypted object storage for optional cloud images (only if user opts-in), otherwise images processed & discarded client-side.  
  - Analytics & experimentation: event tracking, metrics pipeline, dashboards.  
  - Coach dashboard: web app (React) talking to API with role-based access and export endpoints.

- Technology stack recommendations
  - Mobile: Native iOS (Swift) + native Android (Kotlin) OR React Native / Flutter for UI with native modules for ML/vision. Recommendation: React Native to accelerate cross-platform development, but implement ML/vision as native modules to access Core ML and TensorFlow Lite efficiently.  
  - Backend: TypeScript + Node.js (NestJS or Express with TypeORM) OR Python (Django/FastAPI). Recommendation: TypeScript (NestJS) for structured services and faster cross-team development.  
  - Database: PostgreSQL for relational data (users, logs, food DB metadata), Redis for caching and transient state, and optionally ElasticSearch for fast food DB search.  
  - Object storage: AWS S3 (or S3-compatible) with server-side encryption and KMS-managed keys.  
  - ML training: PyTorch or TensorFlow for model development; MLFlow or SageMaker for experiment tracking and model registry.  
  - On-device inference: Core ML models for iOS; TensorFlow Lite or ONNX for Android. Use quantization and pruning to reduce model size.  
  - Barcode scanning & OCR: native libraries (ZXing, ML Kit/Google Vision, Apple Vision) or custom lightweight models for nutrition label OCR.  
  - Auth & payments: Auth0 / Firebase Auth or custom OAuth with JWTs; Stripe for payments/subscriptions.  
  - CI/CD & infra: Kubernetes (EKS/GKE) for backend services, Terraform for infra as code, GitHub Actions for CI/CD.

- Key components and responsibilities
  - Mobile App(s): UI, local DB, camera + barcode + photo UX, on-device ML inference, local analytics, sync client, privacy controls.  
  - API Gateway & Backend Services: authentication, user management, food DB API, logging API, subscriptions, export endpoints, metrics ingestion.  
  - Food DB Service: ingest licensed DB, deduplicate, curate user contributions, provide search and barcode lookup.  
  - ML Training & MLOps: dataset labeling pipeline, training jobs, validation suite, model registry, packaging for mobile.  
  - Coach Dashboard (Web): client management, aggregate views, exports (CSV/PDF), billing and pilot features.  
  - Analytics & Experimentation Platform: event collector, ETL, dashboards for KPI tracking and A/B testing.  
  - Security & Compliance Layer: encryption, audit logs, data retention, role-based access.

- Data flow and integration points
  1. User captures image / barcode / search → mobile app performs on-device inference (photo) or local search.  
  2. User confirms/edit → log item written to local DB and queued for sync.  
  3. Sync sends log to backend API → stored in PostgreSQL; analytics event emitted.  
  4. Backend enriches logs with food DB canonical entries and nutrients.  
  5. Optional: cloud ML (opt-in) can re-analyze images for improved accuracy and feed labeled data into training pipeline.  
  6. Coach dashboard queries aggregated user data via backend APIs; exports generated server-side.  
  7. Integrations: periodic sync with Apple Health / Google Fit for activity/weight; events consumed for adaptive caloric budgets.

# Implementation Milestones
- Phase 1: Core logging & infrastructure (MVP baseline — 12 weeks)
  - Deliverables: mobile apps with search-based logging, barcode scanner, reusable meal templates, local DB + sync, auth, simple backend APIs, Apple Health/Google Fit integration, basic food DB (licensed minimal subset), CSV/PDF export, analytics instrumentation, subscription plumbing (Stripe), privacy-first defaults (no cloud image upload).
  - Success criteria: time-to-log (search/barcode) in analytics, onboarding flow instrumented, user logs persist and sync.

- Phase 2: Photo-assisted logging & ML ops (photo MVP — 12–16 weeks, parallel to Phase 1 late-stage)
  - Deliverables: on-device ML model for basic food recognition (common foods), portion-size UI (user adjust), model packaging for iOS/Android, in-app confirmation flow, human-in-the-loop labeling pipeline, model evaluation metrics, controlled rollout (feature flagging), cloud-opt-in pipeline for improved training data.
  - Success criteria: photo-assist accuracy target (≥70% within ±25% on pilot dataset), median time-to-log via photo flow ≤ target, telemetry for model confidence and correction rates.

- Phase 3: Coach & clinician features + scaling & compliance (12–20 weeks)
  - Deliverables: coach web dashboard (client roster, summaries, exports), role-based permissions, pilot billing, advanced analytics reports (weekly/monthly clinician PDFs), HIPAA readiness plan (if required): encryption at rest with KMS, audit logs, BAA templates, data residency options, admin console for clinics.
  - Success criteria: onboard 10–20 pilot clinicians, 200+ clients, export formats accepted by clinicians, pilot feedback loop.

- Parallel workstreams (ongoing)
  - Food DB curation & moderation pipeline (manual + automated dedupe).  
  - ML dataset expansion and model improvements, international cuisine coverage planning.  
  - A/B experimentation and analytics iterations.  
  - Security hardening and privacy compliance audits.

# Technical Risks and Mitigation
- Risk 1: ML model accuracy insufficient in MVP (varies by cuisine/lighting) → Mitigation: ship photo as assistive (require user confirmation), collect opt-in labeled data, implement human-in-the-loop curation, iterative model retraining, surface confidence indicators and quick edit UI to correct entries.
- Risk 2: On-device inference constraints (model size, latency, battery) → Mitigation: use model quantization, pruning, and efficient architectures (MobileNetV3, EfficientNet-lite); limit classes for MVP; offload heavier processing to optional cloud with explicit opt-in; lazy-load models and background updates.
- Risk 3: Food DB quality (duplicates, wrong nutrition) → Mitigation: use licensed DB for packaged foods as canonical source; implement server-side deduplication, scoring, and curator workflows; version control DB and provide rollback; user reporting UI for incorrect entries.
- Risk 4: Privacy / HIPAA and regulatory exposure if clinician features grow → Mitigation: design data model to separate PHI, minimize data storage, default to on-device processing, opt-in cloud features with explicit consent; prepare HIPAA readiness checklist and isolate clinician data stores; obtain legal review before marketing HIPAA-compliant features.
- Risk 5: Offline sync conflicts and data loss → Mitigation: use deterministic merge rules (last-writer-wins with timestamps and conflict metadata), provide manual conflict resolution UI for users, maintain local change queue, and use server-side validation.
- Risk 6: Cost and complexity of licensed DB and ML infra → Mitigation: begin with a minimal licensed set (core barcodes and popular brands), use open datasets where possible, prioritize high-value items; batch ML training jobs and use spot GPU instances to reduce cost; monitor costs and optimize.
- Risk 7: Security vulnerabilities (data leakage) → Mitigation: enforce TLS everywhere, encrypt at rest, use KMS for keys, implement strong auth (JWT + refresh + device binding), regular pen-testing and code scanning, RBAC for coach dashboard.

# Dependencies
- Internal dependencies (other teams/systems)  
  - Mobile engineering (iOS/Android or cross-platform) for native modules.  
  - ML team (or outsourced ML vendor) for model development, labeling, and MLOps.  
  - Backend/platform engineers for APIs, DB, auth, billing and infra.  
  - Design & UX for prioritizing low-friction flows and accessibility.  
  - Analytics/BI team for event schema and dashboards.  
  - Legal/compliance for privacy policy, terms, and HIPAA readiness.

- External dependencies (third-party services/APIs)  
  - Food database provider(s) (licensed DB + barcode lookup).  
  - Cloud provider (AWS/GCP/Azure) for backend, storage, and training infra.  
  - Model tooling (TensorFlow/PyTorch, Core ML converters, TensorFlow Lite).  
  - Barcode/OCR libraries (ZXing, ML Kit, Apple Vision).  
  - Payment provider (Stripe).  
  - Auth provider (Auth0/Firebase) or internal auth service.  
  - Optional: 3rd-party ML APIs for fallback image processing (explicit opt-in).

- Infrastructure requirements  
  - Cloud compute for backend services (Kubernetes), PostgreSQL, Redis, object storage (S3).  
  - GPU-enabled training nodes (on-demand or managed).  
  - Model registry and CI/CD for model packaging and secure over-the-air model updates.  
  - Monitoring, logging, and alerting (Datadog/Prometheus/Grafana).  
  - Secrets management and KMS for encryption keys.

# Effort Estimation
- Estimated effort: 4–8 months to reach a robust MVP with photo-assisted logging (staged). See phased breakdown.

- Breakdown by component (weeks, approximate; assumes a core team: 2 mobile engineers, 2 backend engineers, 1 ML engineer, 1 designer, 1 QA, 1 product manager):
  - Phase 1 (Core logging & infra) — 10–12 weeks
    - Mobile UI, local DB, sync client: 4–6 weeks (2 engineers parallel)  
    - Backend APIs, auth, PostgreSQL setup, basic food DB ingestion: 4–6 weeks (2 engineers)  
    - Barcode scanner, search UX, reusable meals: 2–4 weeks  
    - Apple Health / Google Fit integration: 1–2 weeks  
    - Analytics instrumentation & basic dashboards: 2 weeks  
  - Phase 2 (Photo-assisted & ML ops) — 12–16 weeks (parallel ML + mobile work)
    - Initial model research & prototype (data collection, baseline model): 4–6 weeks (ML)  
    - On-device model integration (Core ML + TFLite modules), camera UX: 4–6 weeks (mobile)  
    - Human-in-the-loop data labeling pipeline & MLOps setup: 4–6 weeks (ML + backend)  
    - Telemetry & evaluation harness for photo accuracy: 2–4 weeks  
  - Phase 3 (Coach dashboard & compliance) — 8–12 weeks
    - Web coach dashboard (React): 4–6 weeks  
    - Exports (CSV/PDF) & permissioning: 2–4 weeks  
    - Pilot billing & clinic onboarding, HIPAA readiness scoping: 2–4 weeks

- Areas requiring further technical investigation  
  1. Food DB options and licensing costs (vendor proposals, scope of included items).  
  2. Availability and size of labeled datasets for training food recognition and portion estimation; initial datasets to use.  
  3. Decision on mobile strategy (fully native vs cross-platform + native modules) based on team skills.  
  4. HIPAA/regulatory requirements if clinician features go beyond simple exports — legal assessment needed.  
  5. Expected concurrency and scale to size infrastructure appropriately (number of users, average logs/day).

# Technical Assumptions
- Target initial platforms are iOS and Android (mobile-first) with an optional React web coach dashboard.  
- Default privacy posture: on-device image processing; cloud processing only via explicit opt-in. Cloud opt-in allows collection of labeled data for ML improvement.  
- Food DB will be hybrid: licensed dataset for packaged goods + curated community entries + admin-curated restaurant/menu data over time.  
- Photo-assisted logging will be assistive (user verifies/edits) in MVP — not fully automated acceptance.  
- Clinician features in MVP are limited to exports and a basic web dashboard; full HIPAA compliance is a later milestone if required.  
- Team has or will recruit at least one experienced ML engineer and mobile native expertise for integrating on-device models.  
- Payment/subscription handled by Stripe (or equivalent) with server-side validation and receipts.

If you want, next technical steps I can produce:
- A prioritized engineering backlog (user stories + acceptance criteria) mapped to KPIs.  
- A minimal data schema (logs, food items, user profiles) and sample API contract for mobile ↔ backend.  
- An ML roadmap with dataset requirements, labeling plan, and evaluation metrics for photo accuracy and portion estimation.
