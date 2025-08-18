SELECT name, country
FROM travelers
WHERE NOT country = 'USA' AND NOT country = 'Mexico' AND NOT country = 'Canada';