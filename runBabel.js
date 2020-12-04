const babel = require('@babel/core'); // 1
const fs = require('fs');

const filename = './src/app.js';
const source = fs.readFileSync(filename, 'utf8'); // 2
const presets = ['@babel/preset-react']; // 3
const plugins = [
    '@babel/plugin-transform-template-literals',
    '@babel/plugin-transform-arrow-functions',
];
const { code } = babel.transformSync(source, { // 4
    filename,
    presets,
    plugins,
    configFile: false, // 5
});
console.log(code); // 6