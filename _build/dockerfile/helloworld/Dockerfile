FROM microsoft/dotnet:latest

EXPOSE 5000

# Install supervisor and consul-template
RUN apt-get update
RUN yes | apt-get install wget tar unzip

# s6 overlay
ADD https://github.com/just-containers/s6-overlay/releases/download/v1.17.2.0/s6-overlay-amd64.tar.gz /tmp/s6-overlay.tar.gz
RUN tar xvfz /tmp/s6-overlay.tar.gz -C /; \
rm -rf /etc/s6

RUN wget https://releases.hashicorp.com/consul-template/0.14.0/consul-template_0.14.0_linux_386.zip; \
unzip consul-template_0.14.0_linux_386.zip; \
mv consul-template /bin/consul-template

# Create directory for server files
RUN mkdir /helloworld

COPY s6-etc /etc/s6
RUN chmod -R 755 /etc/s6; \
chmod -R 755 /etc/s6

# Add consul template
COPY appsettings.ctmpl /helloworld/appsettings.ctmpl

# Add server files
ADD swagger_spec /swagger
ADD bin /helloworld/bin
ADD web.config /helloworld/web.config
ADD project.json /helloworld/project.json

WORKDIR /helloworld
ENV NUGET_PACKAGES="/helloworld/.nuget"

RUN dotnet restore --packages .nuget

ENTRYPOINT ["/bin/s6-svscan","/etc/s6"]
CMD []
