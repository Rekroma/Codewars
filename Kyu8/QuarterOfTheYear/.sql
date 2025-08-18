SELECT
  month,
  CASE
    WHEN month <= 3 THEN 1
    WHEN month <= 6 THEN 2
    WHEN month <= 9 THEN 3
    ELSE 4
  END AS res
FROM quarterof;