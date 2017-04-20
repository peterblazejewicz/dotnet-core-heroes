const webpack = require('webpack');
const config = {
  entry: {
    site: './Client/js/site.js',
    vendors: './Client/js/vendors.js'
  },
  output: {
    filename: '[name].js',
    path: __dirname + '/wwwroot/js'
  },
  plugins: [
       new webpack.ProvidePlugin({
            jQuery: 'jquery',
            $: 'jquery',
            jquery: 'jquery',
            Tether: 'tether',
            'window.Tether': 'tether',
            'window.Holder': 'holderjs'
        })
  ]
};
module.exports = config