select
    *
from
    business_partners BP
    inner join people P on P.person_id = BP.person_id
where
    BP.is_client = 1
    and BP.is_supplier = 0
    and BP.external_organization_id is null
    and BP.person_id is not null
    and P.internal_organization_id = 1;