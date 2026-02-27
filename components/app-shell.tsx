import { BarChart3, Building2, Camera, CheckSquare, Mic, ShieldCheck } from 'lucide-react';

const navItems = [
  { label: 'Task list', icon: CheckSquare },
  { label: 'Live proofs', icon: Camera },
  { label: 'Audio log', icon: Mic },
  { label: 'Analytics', icon: BarChart3 },
  { label: 'Companies', icon: Building2 },
  { label: 'Security', icon: ShieldCheck }
];

export function AppShell({ children }: { children: React.ReactNode }) {
  return (
    <div className="mx-auto min-h-screen w-full max-w-7xl px-4 py-4 md:px-8 md:py-8">
      <header className="card mb-4 flex items-center justify-between gap-4 p-4 md:mb-8 md:p-6">
        <div>
          <p className="text-xs font-semibold uppercase tracking-[0.2em] text-accent-600">PROOFLY</p>
          <h1 className="text-xl font-semibold text-slate-900 md:text-2xl">Kontrol değil, şeffaflık.</h1>
        </div>
        <button className="rounded-xl bg-accent-500 px-4 py-2 text-sm font-semibold text-white transition hover:bg-accent-600">
          Start free trial
        </button>
      </header>

      <main className="grid gap-4 md:grid-cols-[220px_1fr] md:gap-8">
        <aside className="card p-3">
          <nav className="grid gap-1">
            {navItems.map(({ label, icon: Icon }) => (
              <button
                className="flex items-center gap-3 rounded-xl px-3 py-2 text-left text-sm font-medium text-slate-600 transition hover:bg-slate-100 hover:text-slate-900"
                key={label}
              >
                <Icon size={16} />
                {label}
              </button>
            ))}
          </nav>
        </aside>
        {children}
      </main>
    </div>
  );
}
