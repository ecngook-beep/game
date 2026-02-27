import type { Config } from 'tailwindcss';

const config: Config = {
  content: ['./app/**/*.{js,ts,jsx,tsx}', './components/**/*.{js,ts,jsx,tsx}'],
  theme: {
    extend: {
      colors: {
        accent: {
          50: '#effbf4',
          100: '#daf5e5',
          500: '#2cb67d',
          600: '#229463'
        }
      },
      boxShadow: {
        card: '0 4px 24px rgba(15, 23, 42, 0.08)'
      }
    }
  },
  plugins: []
};

export default config;
