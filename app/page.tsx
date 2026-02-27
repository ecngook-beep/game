import { AppShell } from '@/components/app-shell';
import { MobileEmployeeCard } from '@/components/mobile-employee-card';
import { ProofFeed } from '@/components/proof-feed';
import { StatCard } from '@/components/stat-card';
import { TaskTable } from '@/components/task-table';

const roleCards = [
  {
    title: 'Admin',
    points: ['Create and isolate companies', 'Manage subscription plans']
  },
  {
    title: 'Manager',
    points: ['Create and assign daily tasks', 'Track proofs live', 'Generate daily reports']
  },
  {
    title: 'Employee',
    points: ['Mobile-first task inbox', 'One-tap completion', 'Upload photo, audio, or note proof']
  }
];

export default function HomePage() {
  return (
    <AppShell>
      <div className="space-y-4 md:space-y-8">
        <section className="grid gap-3 sm:grid-cols-2 xl:grid-cols-4">
          <StatCard label="Active companies" value="42" description="Multi-tenant companies under one secure stack" />
          <StatCard label="Tasks completed today" value="1,284" description="With timestamp and GPS metadata" />
          <StatCard label="Live proof uploads" value="312" description="Photo, audio and text proof records" />
          <StatCard label="Report accuracy" value="98.7%" description="Automatically consolidated daily reports" />
        </section>

        <section className="grid gap-4 xl:grid-cols-[1fr_320px]">
          <TaskTable />
          <ProofFeed />
        </section>

        <section className="grid gap-4 lg:grid-cols-[1fr_300px]">
          <article className="card p-4">
            <h2 className="text-lg font-semibold">Role-based workflow</h2>
            <div className="mt-4 grid gap-3 md:grid-cols-3">
              {roleCards.map((role) => (
                <div className="rounded-xl border border-slate-200 p-3" key={role.title}>
                  <h3 className="font-semibold text-slate-900">{role.title}</h3>
                  <ul className="mt-2 list-inside list-disc space-y-1 text-sm text-slate-600">
                    {role.points.map((point) => (
                      <li key={point}>{point}</li>
                    ))}
                  </ul>
                </div>
              ))}
            </div>
          </article>
          <MobileEmployeeCard />
        </section>
      </div>
    </AppShell>
  );
}
