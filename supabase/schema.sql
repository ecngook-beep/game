create table if not exists companies (
  id uuid primary key default gen_random_uuid(),
  name text not null,
  plan text not null default 'starter',
  created_at timestamptz not null default now()
);

create table if not exists profiles (
  id uuid primary key references auth.users(id) on delete cascade,
  company_id uuid not null references companies(id) on delete cascade,
  full_name text not null,
  role text not null check (role in ('admin', 'manager', 'employee')),
  created_at timestamptz not null default now()
);

create table if not exists tasks (
  id uuid primary key default gen_random_uuid(),
  company_id uuid not null references companies(id) on delete cascade,
  created_by uuid not null references profiles(id) on delete cascade,
  assignee_id uuid not null references profiles(id) on delete cascade,
  title text not null,
  details text,
  due_at timestamptz not null,
  status text not null default 'open' check (status in ('open', 'in_progress', 'done')),
  created_at timestamptz not null default now()
);

create table if not exists proofs (
  id uuid primary key default gen_random_uuid(),
  task_id uuid not null references tasks(id) on delete cascade,
  employee_id uuid not null references profiles(id) on delete cascade,
  proof_type text not null check (proof_type in ('photo', 'audio', 'note')),
  text_note text,
  file_path text,
  metadata jsonb not null default '{}'::jsonb,
  created_at timestamptz not null default now()
);
