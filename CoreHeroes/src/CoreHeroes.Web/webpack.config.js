const webpack = require('webpack');
const environment = process.env.ASPNETCORE_ENVIRONMENT || 'Production';

module.exports = {
    entry: {
        site: './Client/js/site.js',
        vendors: './Client/js/vendors.js'
    },
    output: {
        filename: (environment === 'Development')
            ? '[name].js'
            : '[name].min.js',
        path: __dirname + '/wwwroot/js'
    },
    plugins: [new webpack.ProvidePlugin({
            jQuery: 'jquery',
            $: 'jquery',
            jquery: 'jquery',
            Tether: 'tether',
            'window.Tether': 'tether',
            'window.Holder': 'holderjs'
        })]
};

if (process.env.ASPNETCORE_ENVIRONMENT !== 'Development') {
    module.exports.plugins = (module.exports.plugins || []).concat([
        new webpack.DefinePlugin({
            'process.env': {
                NODE_ENV: '"Production"'
            }
        }),
        new webpack
            .optimize
            .UglifyJsPlugin({
                sourceMap: true,
                compress: {
                    warnings: false
                }
            }),
        new webpack.LoaderOptionsPlugin({minimize: true})
    ])
}