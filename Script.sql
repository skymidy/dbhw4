with sort as (
	SELECT 
		COUNT ( DISTINCT Author ) as quantity,
		TopicId
	FROM 
		Messages
	GROUP BY TopicId
)
SELECT 
	t.Id,
	t.Name,
	t.CreationDate,
	(SELECT Content FROM Messages WHERE TopicId = t.Id LIMIT 1) as "Message Content",	
	t.Author,
	(SELECT Content FROM CreationDate WHERE TopicId = t.Id LIMIT 1) as "Message Creation Date"
FROM
	Topics t
WHERE
	s.quantity > 2
JOIN
	sort s using (TopicId);