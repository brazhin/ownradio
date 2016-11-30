package ownradio.domain;

import lombok.Getter;
import lombok.Setter;
import org.hibernate.annotations.Type;

import javax.persistence.Entity;
import java.util.UUID;

/**
 * Created by a.polunina on 29.11.2016.
 */
@Getter
@Setter
//@Entity
public class NextTrack {
	private Integer methodid;

	@Type(type="pg-uuid")
	private UUID trackid;
}
