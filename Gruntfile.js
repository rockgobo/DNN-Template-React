module.exports = function (grunt) {
    grunt.initConfig({
        watch: {
            files: ['./src/*'],
            tasks: ['babel'],
        },
        babel: {
            options: {
                sourceMap: false,
                presets: ["@babel/preset-env", "@babel/preset-react"]
            },
            dist: {
                files: [{
                    expand: true,
                    cwd: './src',
                    src: ['*.js'],
                    dest: './dist',
                    ext: '.js'
                }]
            }
        }
    });
    grunt.loadNpmTasks('grunt-babel');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.registerTask('default', ['babel']);
}