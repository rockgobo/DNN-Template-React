module.exports = {
	dev: {
		files: {
			'<%= resources %>/scripts/app.bundle.js': '<%= resources %>/scripts/app.js'
		},
		options: {
			browserifyOptions: {
				debug: true
			},
			transform: [
				['babelify', {
					presets: ["env", "react"]
				}]
			],
			plugin: ['exorcist']
		}
	},
	dist: {
		files: {
			'<%= resources %>/scripts/app.bundle.js': '<%= resources %>/scripts/app.js'
		},
		options: {
			browserifyOptions: {
				debug: false
			},
			transform: [
				['babelify', {
					presets: ["env", "react"]
				}],
				'uglifyify'
			]
		}
	}
};