/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
		'./src/**/*.{ts,css}',
    './Pages/**/*.cshtml',
    './Components/**/*.cshtml',
  ],
	theme: {
		container: {
      center: true,
    },
    extend: {},
  },
  plugins: [],
}
