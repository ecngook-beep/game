import { proofs } from '@/lib/mock-data';

export function ProofFeed() {
  return (
    <section className="card p-4">
      <div className="mb-4 flex items-center justify-between">
        <h2 className="text-lg font-semibold">Live proof feed</h2>
        <span className="rounded-full bg-accent-100 px-2 py-1 text-xs font-semibold text-accent-600">Realtime</span>
      </div>
      <div className="space-y-3">
        {proofs.map((proof) => (
          <article className="rounded-xl border border-slate-200 p-3" key={proof.id}>
            <div className="flex items-center justify-between gap-3">
              <p className="font-medium text-slate-900">{proof.employee}</p>
              <p className="text-xs uppercase text-slate-500">{proof.type}</p>
            </div>
            <p className="mt-1 text-sm text-slate-600">{proof.task}</p>
            <p className="mt-2 text-xs text-slate-500">
              {proof.createdAt} • {proof.gps}
            </p>
          </article>
        ))}
      </div>
    </section>
  );
}
