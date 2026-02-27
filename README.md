# PROOFLY

PROOFLY is a modern SaaS workforce transparency platform built with **Next.js + Tailwind + Supabase**.

**Tagline:** _Kontrol değil, şeffaflık._

## Core Product Areas

- Multi-tenant company model (admin-owned)
- Manager task assignment and live proof tracking
- Employee mobile-first task completion with one-tap proof uploads
- Proof payloads with timestamp + GPS metadata
- Dashboard analytics for daily reporting

## Local Development

```bash
npm install
npm run dev
```

Create an `.env.local` from `.env.example` and provide your Supabase credentials.

## Supabase

- SQL schema is in `supabase/schema.sql`.
- `lib/supabase.ts` exports a browser client helper.

## Suggested Next Steps

1. Add Supabase Auth flows for admin/manager/employee onboarding.
2. Connect task + proof tables to server actions and route handlers.
3. Add storage buckets for photo/audio proof uploads.
4. Enable realtime subscriptions for live proof feed updates.
