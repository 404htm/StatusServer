module.exports = function (grunt) {
	grunt.initConfig({
		bower: {
			install: {
				options: {
					targetDir: "wwwroot/lib",
					layout: "byComponent",
					cleanTargetDir: false
				}
			}
		},
		less: {
			development: {
				options: {
					compress: false,
				},
				files: { "wwwroot/css/styles.css": "wwwroot/css/styles.less" }
			},
			production: {
				options: {
					compress: true,
				},
				files: { "wwwroot/css/styles.css": "wwwroot/css/styles.less" }
			}
		},
		watch: {
			styles: {
				files: ['css/**/*.less'], // which files to watch
				tasks: ['less'],
				options: {
					nospawn: true
				}
			}
		}
	});

	

	grunt.loadNpmTasks("grunt-bower-task");
	grunt.loadNpmTasks('grunt-contrib-less');

	grunt.registerTask("default", ["bower:install"]);
	grunt.registerTask('default', ['less']);
};