<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/dotnet_books">
		<html>
			<head>
				<title>DotNet Books</title>
			</head>
			<body>
				<ul>
					<xsl:for-each select="Customer">
						<li>
							<xsl:value-of select="Name" >
						</li>
					</xsl:for-each>
				</ul>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
