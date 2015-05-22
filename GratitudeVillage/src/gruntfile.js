module.exports = function (grunt) {

    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        compass: {
            // RadioTimes
            GratitudeBootStrap: {
                options: {
                    //basePath : '',
                    sassDir: 'assets/sass',
                    cssDir: 'assets/css',
                    imagesDir: 'assets/images',
                    generatedImagesDir: 'assets/images',
                    outputStyle: 'compressed',
                    watch: false
                }
            }
        }
    });

    ////Load Task(s)
    grunt.loadNpmTasks('grunt-contrib-compass');

    ////Register Task(s).
    grunt.registerTask('default', ['compass:GratitudeBootStrap']);

};