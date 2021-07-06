docker image build -t unixdotnetwebapi .

docker run -it -v "C:\.......\dotnetunixwebapi":/work -p5000:5000 unixdotnetwebapi bash
