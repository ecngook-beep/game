import clsx from 'clsx';
import { tasks } from '@/lib/mock-data';

const statusStyles = {
  open: 'bg-slate-100 text-slate-600',
  in_progress: 'bg-amber-100 text-amber-700',
  done: 'bg-accent-100 text-accent-600'
};

export function TaskTable() {
  return (
    <section className="card overflow-hidden">
      <div className="border-b border-slate-200 p-4">
        <h2 className="text-lg font-semibold">Today&apos;s task list</h2>
      </div>
      <div className="overflow-x-auto">
        <table className="w-full min-w-[560px] text-left text-sm">
          <thead className="bg-slate-50 text-slate-500">
            <tr>
              <th className="px-4 py-3 font-medium">Task</th>
              <th className="px-4 py-3 font-medium">Assignee</th>
              <th className="px-4 py-3 font-medium">Due</th>
              <th className="px-4 py-3 font-medium">Proofs</th>
              <th className="px-4 py-3 font-medium">Status</th>
            </tr>
          </thead>
          <tbody>
            {tasks.map((task) => (
              <tr className="border-t border-slate-200" key={task.id}>
                <td className="px-4 py-3">
                  <p className="font-medium text-slate-900">{task.title}</p>
                  <p className="text-xs text-slate-500">{task.id}</p>
                </td>
                <td className="px-4 py-3">{task.assignee}</td>
                <td className="px-4 py-3">{task.dueAt}</td>
                <td className="px-4 py-3">{task.proofCount}</td>
                <td className="px-4 py-3">
                  <span className={clsx('rounded-full px-2.5 py-1 text-xs font-semibold', statusStyles[task.status])}>
                    {task.status.replace('_', ' ')}
                  </span>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </section>
  );
}
