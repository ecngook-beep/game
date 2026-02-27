export type Role = 'admin' | 'manager' | 'employee';

export interface Task {
  id: string;
  title: string;
  assignee: string;
  dueAt: string;
  status: 'open' | 'in_progress' | 'done';
  proofCount: number;
}

export interface Proof {
  id: string;
  employee: string;
  task: string;
  type: 'photo' | 'audio' | 'note';
  createdAt: string;
  gps: string;
}
