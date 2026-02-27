import type { Proof, Task } from './types';

export const tasks: Task[] = [
  {
    id: 'TSK-104',
    title: 'Storefront cleanliness check',
    assignee: 'Ayşe Demir',
    dueAt: '09:00',
    status: 'done',
    proofCount: 2
  },
  {
    id: 'TSK-105',
    title: 'Daily inventory photo scan',
    assignee: 'Mert Kaya',
    dueAt: '10:30',
    status: 'in_progress',
    proofCount: 1
  },
  {
    id: 'TSK-106',
    title: 'Cash register balancing note',
    assignee: 'Elif Akın',
    dueAt: '12:00',
    status: 'open',
    proofCount: 0
  }
];

export const proofs: Proof[] = [
  {
    id: 'PRF-901',
    employee: 'Ayşe Demir',
    task: 'Storefront cleanliness check',
    type: 'photo',
    createdAt: '08:42',
    gps: '41.031, 28.971'
  },
  {
    id: 'PRF-902',
    employee: 'Mert Kaya',
    task: 'Daily inventory photo scan',
    type: 'audio',
    createdAt: '09:17',
    gps: '41.019, 28.965'
  },
  {
    id: 'PRF-903',
    employee: 'Ayşe Demir',
    task: 'Storefront cleanliness check',
    type: 'note',
    createdAt: '09:28',
    gps: '41.030, 28.970'
  }
];
