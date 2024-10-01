# Use the official Tegola image
FROM gospatial/tegola

# Expose port 80 to the host
EXPOSE 80

# Optionally, if you have local configurations and data sources:
COPY config.toml /opt/tegola_config/config.toml

CMD ["serve", "--config", "/opt/tegola_config/config.toml"]