import type { Metadata } from 'next';
import './globals.css';

export const metadata: Metadata = {
  title: 'PROOFLY | Workforce Transparency Platform',
  description: 'Kontrol değil, şeffaflık. Assign tasks and collect proof in real time.'
};

export default function RootLayout({ children }: { children: React.ReactNode }) {
  return (
    <html lang="tr">
      <body>{children}</body>
    </html>
  );
}
