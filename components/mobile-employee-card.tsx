export function MobileEmployeeCard() {
  return (
    <section className="card p-4 md:max-w-sm">
      <h2 className="text-lg font-semibold">Employee quick action</h2>
      <p className="mt-1 text-sm text-slate-600">One-tap completion optimized for mobile teams.</p>
      <div className="mt-4 grid grid-cols-2 gap-2 text-sm">
        <button className="rounded-xl bg-accent-500 px-3 py-3 font-semibold text-white">Take photo</button>
        <button className="rounded-xl bg-slate-900 px-3 py-3 font-semibold text-white">Record audio</button>
        <button className="rounded-xl border border-slate-200 px-3 py-3 font-semibold text-slate-700">Add note</button>
        <button className="rounded-xl border border-slate-200 px-3 py-3 font-semibold text-slate-700">Mark done</button>
      </div>
    </section>
  );
}
