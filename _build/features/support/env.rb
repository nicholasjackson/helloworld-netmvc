require 'cucumber-api'
require 'minke'

discovery = Minke::Docker::ServiceDiscovery.new 'config.yml'
$SERVER_PATH = "http://#{discovery.public_address_for 'helloworld', '5000', :cucumber}"

Before do |scenario|

end

After do |scenario|

end
