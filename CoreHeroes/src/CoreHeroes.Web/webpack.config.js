const webpack = require('webpack');
const config = {
  entry: {
    site: './js/site.js',
    vendors: './js/vendors.js'
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
            'window.Tether': 'tether'})
  ]
};
module.exports = config