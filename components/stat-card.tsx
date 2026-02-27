interface StatCardProps {
  label: string;
  value: string;
  description: string;
}

export function StatCard({ label, value, description }: StatCardProps) {
  return (
    <article className="card p-4">
      <p className="text-sm text-slate-500">{label}</p>
      <p className="mt-2 text-2xl font-semibold text-slate-900">{value}</p>
      <p className="mt-2 text-sm text-slate-600">{description}</p>
    </article>
  );
}
