/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml',
        './Pages/**/*.razor',
        './Views/**/*.razor',
        './Shared/**/*.razor',
        './Shared/**/*.cshtml',
        './Components/**/*.razor',
        './Components/**/*.cshtml'


    ],
    theme: {
        extend: {
            screens: {
                tablet: "768px",
                desktop: "1024px",
                largeDesktop: "1280px",

            }

            ,
            colors: {
                black: {
                    primary: 'black',
                    secondary: '#333136'
                },
                white: {
                    primary: '#FFFFFF',
                    secondary: '#F1F3F5'
                },

            },

            fontFamily: {
                primary: ['sans-serif']
            }
        },
    },
    plugins: [require('@tailwindcss/forms')],
}
