<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/08/17 14:19:30">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="12">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="9" type="1" entityID="14" dl="0" group="-1" locked="0" />
        <SceneShape id="10" type="1" entityID="15" dl="0" group="-1" locked="0" />
        <SceneShape id="11" type="1" entityID="16" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="17">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="4 -10 -16.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="4 -10 -5.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="4 -10 -16.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="20 6 -5.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="20 6 -16.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="20 6 -5.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="13" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="29 19 -4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="15" classname="path_node" gametype="Torque" isPointEntity="1" origin="29 17 -4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="16" classname="path_node" gametype="Torque" isPointEntity="1" origin="29 19 -4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="195">
                    <Brush id="3" owner="0" type="0" pos="0 10 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 10 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 10 0.25" />
                            <Vertex pos="2 10 -0.25" />
                            <Vertex pos="2 -18 0.25" />
                            <Vertex pos="2 -18 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -18 0.25" />
                            <Vertex pos="-2 -18 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -5.65685" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -18" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="8 18 5.75" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 18 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="4 18 5.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 18 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                            <Vertex pos="-6 -6 0.25" />
                            <Vertex pos="-6 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="16 18 5.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 18 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-6 2 0.25" />
                            <Vertex pos="-6 2 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_trim" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="8 -2 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -2 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2 6.25" />
                            <Vertex pos="-4 2 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 2 6.25" />
                            <Vertex pos="-6 2 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2048 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="24 18 -11.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 18 0 0 1 -11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 6.25" />
                            <Vertex pos="6 6 5.75" />
                            <Vertex pos="6 -6 6.25" />
                            <Vertex pos="6 -6 5.75" />
                            <Vertex pos="-6 6 6.25" />
                            <Vertex pos="-6 6 5.75" />
                            <Vertex pos="-6 -6 6.25" />
                            <Vertex pos="-6 -6 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="24 18 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 18 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 6.25" />
                            <Vertex pos="6 6 5.75" />
                            <Vertex pos="6 -6 6.25" />
                            <Vertex pos="6 -6 5.75" />
                            <Vertex pos="-6 6 6.25" />
                            <Vertex pos="-6 6 5.75" />
                            <Vertex pos="-6 -6 6.25" />
                            <Vertex pos="-6 -6 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="8 10 7.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 10 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -1.25" />
                            <Vertex pos="2 2 -1.75" />
                            <Vertex pos="2 -2 1.75" />
                            <Vertex pos="2 -2 1.25" />
                            <Vertex pos="-2 2 -1.25" />
                            <Vertex pos="-2 2 -1.75" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -2 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.6 0.8 -0.2" album="" material="bm_friction_grass" texgens="1 0 0 2048 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.6 -0.8 -0.2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="4 6 8.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 6 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="17.75 22 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 22 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 6.25" />
                            <Vertex pos="0.25 2 5.75" />
                            <Vertex pos="0.25 -10 6.25" />
                            <Vertex pos="0.25 -10 5.75" />
                            <Vertex pos="-0.25 2 6.25" />
                            <Vertex pos="-0.25 2 5.75" />
                            <Vertex pos="-0.25 -10 6.25" />
                            <Vertex pos="-0.25 -10 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="17.75 11.75 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 11.75 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 8" />
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 -0.25 8" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="-0.25 0.25 8" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 -0.25 8" />
                            <Vertex pos="-0.25 -0.25 4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="17.75 24.25 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 24.25 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 8" />
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 -0.25 8" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="-0.25 0.25 8" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 -0.25 8" />
                            <Vertex pos="-0.25 -0.25 4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="24 24.25 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24.25 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 6.25" />
                            <Vertex pos="6.5 0.25 5.75" />
                            <Vertex pos="6.5 -0.25 6.25" />
                            <Vertex pos="6.5 -0.25 5.75" />
                            <Vertex pos="-6.5 0.25 6.25" />
                            <Vertex pos="-6.5 0.25 5.75" />
                            <Vertex pos="-6.5 -0.25 6.25" />
                            <Vertex pos="-6.5 -0.25 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="24 11.75 -11.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 11.75 0 0 1 -11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 6.25" />
                            <Vertex pos="6.5 0.25 5.75" />
                            <Vertex pos="6.5 -0.25 6.25" />
                            <Vertex pos="6.5 -0.25 5.75" />
                            <Vertex pos="-6.5 0.25 6.25" />
                            <Vertex pos="-6.5 0.25 5.75" />
                            <Vertex pos="-6.5 -0.25 6.25" />
                            <Vertex pos="-6.5 -0.25 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="24 11.75 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 11.75 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 6.25" />
                            <Vertex pos="6.5 0.25 5.75" />
                            <Vertex pos="6.5 -0.25 6.25" />
                            <Vertex pos="6.5 -0.25 5.75" />
                            <Vertex pos="-6.5 0.25 6.25" />
                            <Vertex pos="-6.5 0.25 5.75" />
                            <Vertex pos="-6.5 -0.25 6.25" />
                            <Vertex pos="-6.5 -0.25 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="30.25 18 -11.75" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 18 0 0 1 -11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 6.25" />
                            <Vertex pos="0.25 6 5.75" />
                            <Vertex pos="0.25 -6 6.25" />
                            <Vertex pos="0.25 -6 5.75" />
                            <Vertex pos="-0.25 6 6.25" />
                            <Vertex pos="-0.25 6 5.75" />
                            <Vertex pos="-0.25 -6 6.25" />
                            <Vertex pos="-0.25 -6 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="30.25 18 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 18 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 6.25" />
                            <Vertex pos="0.25 6 5.75" />
                            <Vertex pos="0.25 -6 6.25" />
                            <Vertex pos="0.25 -6 5.75" />
                            <Vertex pos="-0.25 6 6.25" />
                            <Vertex pos="-0.25 6 5.75" />
                            <Vertex pos="-0.25 -6 6.25" />
                            <Vertex pos="-0.25 -6 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="30.25 18 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 18 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 8" />
                            <Vertex pos="0.25 6 4" />
                            <Vertex pos="0.25 -6 8" />
                            <Vertex pos="0.25 -6 4" />
                            <Vertex pos="-0.25 6 8" />
                            <Vertex pos="-0.25 6 4" />
                            <Vertex pos="-0.25 -6 8" />
                            <Vertex pos="-0.25 -6 4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="30.25 11.75 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 11.75 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 8" />
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 -0.25 8" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="-0.25 0.25 8" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 -0.25 8" />
                            <Vertex pos="-0.25 -0.25 4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="30.25 24.25 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 24.25 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 8" />
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 -0.25 8" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="-0.25 0.25 8" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 -0.25 8" />
                            <Vertex pos="-0.25 -0.25 4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="8 14 3.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 14 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -9" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -9" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -9" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1536 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -2048 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="29 18 -10.5" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 18 0 0 1 -10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7" />
                            <Vertex pos="1 2 5" />
                            <Vertex pos="1 -2 7" />
                            <Vertex pos="1 -2 5" />
                            <Vertex pos="-1 2 7" />
                            <Vertex pos="-1 2 5" />
                            <Vertex pos="-1 -2 7" />
                            <Vertex pos="-1 -2 5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank2" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank2" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile08_A" texgens="1 0 0 -768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5" album="" material="bm_grid_blank2" texgens="-1 0 0 640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="1" type="999" pos="4 -10 -16.25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -10 0 0 1 -16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_mp2" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_mp2" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_mp2" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_mp2" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile01_A" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="5" type="999" pos="20 6 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 6 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_mp2" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_mp2" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_mp2" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_mp2" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile01_A" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="13" type="999" pos="29 19 -10.5" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 19 0 0 1 -10.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 3 7" />
                            <Vertex pos="1 3 5" />
                            <Vertex pos="1 -3 7" />
                            <Vertex pos="1 -3 5" />
                            <Vertex pos="-1 3 5" />
                            <Vertex pos="-1 -3 5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank2" texgens="0 1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -3" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="0 -1 -0 -3" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="-0.707107 0 0.707107 -4.24264" album="" material="bm_tile01_A" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 5" album="" material="bm_grid_blank2" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="24 18 -6.875" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 18 0 0 1 -6.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1.99999 6.125" />
                            <Vertex pos="2.5 2.49999 5.875" />
                            <Vertex pos="2 -2.00001 6.125" />
                            <Vertex pos="2.5 -2.50001 5.875" />
                            <Vertex pos="-2 1.99999 6.125" />
                            <Vertex pos="-2.5 2.49999 5.875" />
                            <Vertex pos="-2 -2.00001 6.125" />
                            <Vertex pos="-2.5 -2.50001 5.875" />
                        </Vertices>
                        <Face id="0" plane="0.447214 -0 0.894427 -6.37279" album="" material="bm_edge_white" texgens="0 1 0 -383.998 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.447214 0 0.894427 -6.37279" album="" material="bm_edge_white" texgens="0 -1 0 511.998 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.447214 0.894427 -6.37279" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.447214 0.894427 -6.3728" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_friction_bounce_high" texgens="1 0 0 512 0 -1 0 511.998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 255.999 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="24 24.25 -11.375" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24.25 0 0 1 -11.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 6.125" />
                            <Vertex pos="6 0.125 5.875" />
                            <Vertex pos="6 -0.125 6.125" />
                            <Vertex pos="6 -0.125 5.875" />
                            <Vertex pos="-6 0.125 6.125" />
                            <Vertex pos="-6 0.125 5.875" />
                            <Vertex pos="-6 -0.125 6.125" />
                            <Vertex pos="-6 -0.125 5.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="24 24.25 -7.625" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24.25 0 0 1 -7.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 6.125" />
                            <Vertex pos="6 0.125 5.875" />
                            <Vertex pos="6 -0.125 6.125" />
                            <Vertex pos="6 -0.125 5.875" />
                            <Vertex pos="-6 0.125 6.125" />
                            <Vertex pos="-6 0.125 5.875" />
                            <Vertex pos="-6 -0.125 6.125" />
                            <Vertex pos="-6 -0.125 5.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="29.875 24.25 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 29.875 0 1 0 24.25 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 7.75" />
                            <Vertex pos="0.125 0.125 4.25" />
                            <Vertex pos="0.125 -0.125 7.75" />
                            <Vertex pos="0.125 -0.125 4.25" />
                            <Vertex pos="-0.125 0.125 7.75" />
                            <Vertex pos="-0.125 0.125 4.25" />
                            <Vertex pos="-0.125 -0.125 7.75" />
                            <Vertex pos="-0.125 -0.125 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_wood" texgens="1 0 0 5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.25" album="" material="bm_wood" texgens="-1 0 0 -5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="18.125 24.25 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 18.125 0 1 0 24.25 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 7.75" />
                            <Vertex pos="0.125 0.125 4.25" />
                            <Vertex pos="0.125 -0.125 7.75" />
                            <Vertex pos="0.125 -0.125 4.25" />
                            <Vertex pos="-0.125 0.125 7.75" />
                            <Vertex pos="-0.125 0.125 4.25" />
                            <Vertex pos="-0.125 -0.125 7.75" />
                            <Vertex pos="-0.125 -0.125 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_wood" texgens="1 0 0 2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.25" album="" material="bm_wood" texgens="-1 0 0 -2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="17.75 23.875 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 23.875 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 7.75" />
                            <Vertex pos="0.125 0.125 4.25" />
                            <Vertex pos="0.125 -0.125 7.75" />
                            <Vertex pos="0.125 -0.125 4.25" />
                            <Vertex pos="-0.125 0.125 7.75" />
                            <Vertex pos="-0.125 0.125 4.25" />
                            <Vertex pos="-0.125 -0.125 7.75" />
                            <Vertex pos="-0.125 -0.125 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.25" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="17.75 22 -11.375" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 22 0 0 1 -11.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 6.125" />
                            <Vertex pos="0.125 2 5.875" />
                            <Vertex pos="0.125 -2 6.125" />
                            <Vertex pos="0.125 -2 5.875" />
                            <Vertex pos="-0.125 2 6.125" />
                            <Vertex pos="-0.125 2 5.875" />
                            <Vertex pos="-0.125 -2 6.125" />
                            <Vertex pos="-0.125 -2 5.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="17.75 20.125 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 20.125 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 7.75" />
                            <Vertex pos="0.125 0.125 4.25" />
                            <Vertex pos="0.125 -0.125 7.75" />
                            <Vertex pos="0.125 -0.125 4.25" />
                            <Vertex pos="-0.125 0.125 7.75" />
                            <Vertex pos="-0.125 0.125 4.25" />
                            <Vertex pos="-0.125 -0.125 7.75" />
                            <Vertex pos="-0.125 -0.125 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.25" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="17.75 22 -7.625" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 22 0 0 1 -7.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 6.125" />
                            <Vertex pos="0.125 2 5.875" />
                            <Vertex pos="0.125 -2 6.125" />
                            <Vertex pos="0.125 -2 5.875" />
                            <Vertex pos="-0.125 2 6.125" />
                            <Vertex pos="-0.125 2 5.875" />
                            <Vertex pos="-0.125 -2 6.125" />
                            <Vertex pos="-0.125 -2 5.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="17.75 15.875 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 15.875 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 7.75" />
                            <Vertex pos="0.125 0.125 4.25" />
                            <Vertex pos="0.125 -0.125 7.75" />
                            <Vertex pos="0.125 -0.125 4.25" />
                            <Vertex pos="-0.125 0.125 7.75" />
                            <Vertex pos="-0.125 0.125 4.25" />
                            <Vertex pos="-0.125 -0.125 7.75" />
                            <Vertex pos="-0.125 -0.125 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.25" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="17.75 14 -11.375" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 14 0 0 1 -11.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 6.125" />
                            <Vertex pos="0.125 2 5.875" />
                            <Vertex pos="0.125 -2 6.125" />
                            <Vertex pos="0.125 -2 5.875" />
                            <Vertex pos="-0.125 2 6.125" />
                            <Vertex pos="-0.125 2 5.875" />
                            <Vertex pos="-0.125 -2 6.125" />
                            <Vertex pos="-0.125 -2 5.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="17.75 12.125 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 12.125 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 7.75" />
                            <Vertex pos="0.125 0.125 4.25" />
                            <Vertex pos="0.125 -0.125 7.75" />
                            <Vertex pos="0.125 -0.125 4.25" />
                            <Vertex pos="-0.125 0.125 7.75" />
                            <Vertex pos="-0.125 0.125 4.25" />
                            <Vertex pos="-0.125 -0.125 7.75" />
                            <Vertex pos="-0.125 -0.125 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.25" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="17.75 14 -7.625" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 14 0 0 1 -7.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 6.125" />
                            <Vertex pos="0.125 2 5.875" />
                            <Vertex pos="0.125 -2 6.125" />
                            <Vertex pos="0.125 -2 5.875" />
                            <Vertex pos="-0.125 2 6.125" />
                            <Vertex pos="-0.125 2 5.875" />
                            <Vertex pos="-0.125 -2 6.125" />
                            <Vertex pos="-0.125 -2 5.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="24 11.75 -11.375" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 11.75 0 0 1 -11.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 6.125" />
                            <Vertex pos="6 0.125 5.875" />
                            <Vertex pos="6 -0.125 6.125" />
                            <Vertex pos="6 -0.125 5.875" />
                            <Vertex pos="-6 0.125 6.125" />
                            <Vertex pos="-6 0.125 5.875" />
                            <Vertex pos="-6 -0.125 6.125" />
                            <Vertex pos="-6 -0.125 5.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="24 11.75 -7.625" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 11.75 0 0 1 -7.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 6.125" />
                            <Vertex pos="6 0.125 5.875" />
                            <Vertex pos="6 -0.125 6.125" />
                            <Vertex pos="6 -0.125 5.875" />
                            <Vertex pos="-6 0.125 6.125" />
                            <Vertex pos="-6 0.125 5.875" />
                            <Vertex pos="-6 -0.125 6.125" />
                            <Vertex pos="-6 -0.125 5.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.875" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="29.875 11.75 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 29.875 0 1 0 11.75 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 7.75" />
                            <Vertex pos="0.125 0.125 4.25" />
                            <Vertex pos="0.125 -0.125 7.75" />
                            <Vertex pos="0.125 -0.125 4.25" />
                            <Vertex pos="-0.125 0.125 7.75" />
                            <Vertex pos="-0.125 0.125 4.25" />
                            <Vertex pos="-0.125 -0.125 7.75" />
                            <Vertex pos="-0.125 -0.125 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_wood" texgens="1 0 0 5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.25" album="" material="bm_wood" texgens="-1 0 0 -5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="18.125 11.75 -9.5" rot="1 0 0 0" scale="" transform="1 0 0 18.125 0 1 0 11.75 0 0 1 -9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 7.75" />
                            <Vertex pos="0.125 0.125 4.25" />
                            <Vertex pos="0.125 -0.125 7.75" />
                            <Vertex pos="0.125 -0.125 4.25" />
                            <Vertex pos="-0.125 0.125 7.75" />
                            <Vertex pos="-0.125 0.125 4.25" />
                            <Vertex pos="-0.125 -0.125 7.75" />
                            <Vertex pos="-0.125 -0.125 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_wood" texgens="1 0 0 2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.25" album="" material="bm_wood" texgens="-1 0 0 -2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-12 0 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 0 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2 3.25" />
                            <Vertex pos="2 -2 2.75" />
                            <Vertex pos="2 -4 3.25" />
                            <Vertex pos="2 -4 2.75" />
                            <Vertex pos="-2 -2 2.25" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -4 2.25" />
                            <Vertex pos="-2 -4 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.25 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -384 0.25 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -2.66789" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -3072 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 2.18282" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-16 0 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 0 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2.25" />
                            <Vertex pos="2 4 1.75" />
                            <Vertex pos="2 -4 2.25" />
                            <Vertex pos="2 -4 1.75" />
                            <Vertex pos="-6 4 2.25" />
                            <Vertex pos="-6 4 1.75" />
                            <Vertex pos="-6 -4 2.25" />
                            <Vertex pos="-6 -4 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.75" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="-12 6 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 6 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2 3.25" />
                            <Vertex pos="2 -2 2.75" />
                            <Vertex pos="2 -4 3.25" />
                            <Vertex pos="2 -4 2.75" />
                            <Vertex pos="-2 -2 2.25" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -4 2.25" />
                            <Vertex pos="-2 -4 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.25 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -384 0.25 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -2.66789" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -3072 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 2.18282" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-20 2 -22" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 2 0 0 1 -22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 11.5" />
                            <Vertex pos="6 2 -10" />
                            <Vertex pos="6 -6 11.5" />
                            <Vertex pos="6 -6 -10" />
                            <Vertex pos="-2 2 11.5" />
                            <Vertex pos="-2 2 -10" />
                            <Vertex pos="-2 -6 11.5" />
                            <Vertex pos="-2 -6 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.5" album="" material="bm_tile08_A" texgens="1 0 0 1536 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-4 0 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 0 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2 2.75" />
                            <Vertex pos="2 -2 2.25" />
                            <Vertex pos="2 -4 2.75" />
                            <Vertex pos="2 -4 2.25" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -2 1.25" />
                            <Vertex pos="-2 -4 1.75" />
                            <Vertex pos="-2 -4 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.25 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -384 0.25 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -2.18282" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 1.69775" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-4 6 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 6 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2 2.75" />
                            <Vertex pos="2 -2 2.25" />
                            <Vertex pos="2 -4 2.75" />
                            <Vertex pos="2 -4 2.25" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -2 1.25" />
                            <Vertex pos="-2 -4 1.75" />
                            <Vertex pos="-2 -4 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.25 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -384 0.25 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -2.18282" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -1024 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 1.69775" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-8 0 -11.25" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 -11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2 4.75" />
                            <Vertex pos="2 -2 4.25" />
                            <Vertex pos="2 -4 4.75" />
                            <Vertex pos="2 -4 4.25" />
                            <Vertex pos="-2 -2 2.25" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -4 2.25" />
                            <Vertex pos="-2 -4 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.625 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -384 0.625 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.529999 0 0.847998 -2.96799" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -2048 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.529999 0 -0.847998 2.54399" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-8 6 -11.25" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 6 0 0 1 -11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2 4.75" />
                            <Vertex pos="2 -2 4.25" />
                            <Vertex pos="2 -4 4.75" />
                            <Vertex pos="2 -4 4.25" />
                            <Vertex pos="-2 -2 2.25" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -4 2.25" />
                            <Vertex pos="-2 -4 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.625 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -384 0.625 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.529999 0 0.847998 -2.96799" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -2048 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.529999 0 -0.847998 2.54399" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="24 18 -26" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 18 0 0 1 -26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 20" />
                            <Vertex pos="6 6 -6" />
                            <Vertex pos="6 -6 20" />
                            <Vertex pos="6 -6 -6" />
                            <Vertex pos="-6 6 20" />
                            <Vertex pos="-6 6 -6" />
                            <Vertex pos="-6 -6 20" />
                            <Vertex pos="-6 -6 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile08_A" texgens="1 0 0 1536 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="12 2 -22" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 2 0 0 1 -22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 12" />
                            <Vertex pos="6 2 -10" />
                            <Vertex pos="6 -10 12" />
                            <Vertex pos="6 -10 -10" />
                            <Vertex pos="2 2 12" />
                            <Vertex pos="2 2 -10" />
                            <Vertex pos="2 -10 12" />
                            <Vertex pos="2 -10 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile08_A" texgens="1 0 0 1536 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="0 -8 -12" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -8 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 20 6" />
                            <Vertex pos="2 20 -20" />
                            <Vertex pos="2 0 6" />
                            <Vertex pos="2 0 -20" />
                            <Vertex pos="-2 20 6" />
                            <Vertex pos="-2 20 -20" />
                            <Vertex pos="-2 0 6" />
                            <Vertex pos="-2 0 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -20" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="4 -8 -12" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -8 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14 16 6" />
                            <Vertex pos="14 16 2" />
                            <Vertex pos="14 0 6" />
                            <Vertex pos="14 0 2" />
                            <Vertex pos="-2 16 6" />
                            <Vertex pos="-2 16 2" />
                            <Vertex pos="-2 0 6" />
                            <Vertex pos="-2 0 2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -14" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="8 -8 -12" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -8 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 2" />
                            <Vertex pos="6 4 -20" />
                            <Vertex pos="6 0 2" />
                            <Vertex pos="6 0 -20" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -20" />
                            <Vertex pos="-2 0 2" />
                            <Vertex pos="-2 0 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="4 10 -16.25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 10 0 0 1 -16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -14 0.25" />
                            <Vertex pos="2 -14 -0.25" />
                            <Vertex pos="2 -18 0.25" />
                            <Vertex pos="2 -18 -0.25" />
                            <Vertex pos="-2 -14 0.25" />
                            <Vertex pos="-2 -14 -0.25" />
                            <Vertex pos="-2 -18 0.25" />
                            <Vertex pos="-2 -18 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 14" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -18" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="10 0 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 0 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0 6.25" />
                            <Vertex pos="-4 0 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2560 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="4 -8 -22" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -8 0 0 1 -22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 5.5" />
                            <Vertex pos="2 4 -10" />
                            <Vertex pos="2 0 5.5" />
                            <Vertex pos="2 0 -10" />
                            <Vertex pos="-2 4 5.5" />
                            <Vertex pos="-2 4 -10" />
                            <Vertex pos="-2 0 5.5" />
                            <Vertex pos="-2 0 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.5" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="12 -2 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -2 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0 6.25" />
                            <Vertex pos="-4 0 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3072 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="12 2 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 2 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 0 6.25" />
                            <Vertex pos="-2 0 5.75" />
                            <Vertex pos="-2 -2 6.25" />
                            <Vertex pos="-2 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3072 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="16 -2 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -2 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0 6.25" />
                            <Vertex pos="-4 0 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="10 4 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 4 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0 6.25" />
                            <Vertex pos="-4 0 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2560 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="8 2 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 2 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0 6.25" />
                            <Vertex pos="-4 0 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2048 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="16 0 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 0 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2 6.25" />
                            <Vertex pos="-4 2 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 2 6.25" />
                            <Vertex pos="-6 2 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="18 0 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 0 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0 6.25" />
                            <Vertex pos="-4 0 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4608 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="14 4 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 4 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2 6.25" />
                            <Vertex pos="-4 2 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 2 6.25" />
                            <Vertex pos="-6 2 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3584 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="8 6 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 6 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 0 6.25" />
                            <Vertex pos="-2 0 5.75" />
                            <Vertex pos="-2 -2 6.25" />
                            <Vertex pos="-2 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2048 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="16 6 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 6 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 0 6.25" />
                            <Vertex pos="-2 0 5.75" />
                            <Vertex pos="-2 -2 6.25" />
                            <Vertex pos="-2 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="16 8 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 8 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0 6.25" />
                            <Vertex pos="-4 0 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="10 8 -22.25" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 8 0 0 1 -22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0 6.25" />
                            <Vertex pos="-4 0 5.75" />
                            <Vertex pos="-4 -2 6.25" />
                            <Vertex pos="-4 -2 5.75" />
                            <Vertex pos="-6 0 6.25" />
                            <Vertex pos="-6 0 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2560 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="8 8 -12" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 8 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 4 6" />
                            <Vertex pos="10 4 -20" />
                            <Vertex pos="10 0 6" />
                            <Vertex pos="10 0 -20" />
                            <Vertex pos="-6 4 6" />
                            <Vertex pos="-6 4 -20" />
                            <Vertex pos="-6 0 6" />
                            <Vertex pos="-6 0 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="16 22 -16.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 22 0 0 1 -16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -14 0.25" />
                            <Vertex pos="2 -14 -0.25" />
                            <Vertex pos="2 -18 0.25" />
                            <Vertex pos="2 -18 -0.25" />
                            <Vertex pos="-2 -14 0.25" />
                            <Vertex pos="-2 -14 -0.25" />
                            <Vertex pos="-2 -18 0.25" />
                            <Vertex pos="-2 -18 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 14" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -18" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="16 4 -22" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 4 0 0 1 -22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 5.5" />
                            <Vertex pos="2 4 -10" />
                            <Vertex pos="2 0 5.5" />
                            <Vertex pos="2 0 -10" />
                            <Vertex pos="-2 4 5.5" />
                            <Vertex pos="-2 4 -10" />
                            <Vertex pos="-2 0 5.5" />
                            <Vertex pos="-2 0 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.5" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="4 10 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 10 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 2 0.25" />
                            <Vertex pos="10 2 -0.25" />
                            <Vertex pos="10 -14 0.25" />
                            <Vertex pos="10 -14 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -14 0.25" />
                            <Vertex pos="-2 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 1024 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="8 12 -12" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 12 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 4 6" />
                            <Vertex pos="10 4 -20" />
                            <Vertex pos="10 0 6" />
                            <Vertex pos="10 0 -20" />
                            <Vertex pos="-10 4 6" />
                            <Vertex pos="-10 4 -20" />
                            <Vertex pos="-10 0 6" />
                            <Vertex pos="-10 0 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="8 16 -12" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 16 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 8 6" />
                            <Vertex pos="10 8 -20" />
                            <Vertex pos="10 0 6" />
                            <Vertex pos="10 0 -20" />
                            <Vertex pos="-2 8 6" />
                            <Vertex pos="-2 8 -20" />
                            <Vertex pos="-10 0 6" />
                            <Vertex pos="-10 0 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -7.07107" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="4 26 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 26 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 -10 0.25" />
                            <Vertex pos="10 -10 -0.25" />
                            <Vertex pos="10 -14 0.25" />
                            <Vertex pos="10 -14 -0.25" />
                            <Vertex pos="2 -10 0.25" />
                            <Vertex pos="2 -10 -0.25" />
                            <Vertex pos="-2 -14 0.25" />
                            <Vertex pos="-2 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 8.48528" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 10" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 1024 0 -1 0 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="4 -6 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -6 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 2 0.25" />
                            <Vertex pos="10 2 -0.25" />
                            <Vertex pos="10 -2 0.25" />
                            <Vertex pos="10 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="16 10 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 10 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -18 0.25" />
                            <Vertex pos="2 -18 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -18 0.25" />
                            <Vertex pos="-2 -18 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -18" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="12 18 -11.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 18 0 0 1 -11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 6.25" />
                            <Vertex pos="6 6 5.75" />
                            <Vertex pos="6 -2 6.25" />
                            <Vertex pos="6 -2 5.75" />
                            <Vertex pos="-6 6 6.25" />
                            <Vertex pos="-6 6 5.75" />
                            <Vertex pos="-6 -2 6.25" />
                            <Vertex pos="-6 -2 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="0 18 -11.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 18 0 0 1 -11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 6.25" />
                            <Vertex pos="6 6 5.75" />
                            <Vertex pos="6 -2 6.25" />
                            <Vertex pos="6 -2 5.75" />
                            <Vertex pos="2 2 6.25" />
                            <Vertex pos="2 2 5.75" />
                            <Vertex pos="2 -6 6.25" />
                            <Vertex pos="2 -6 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -5.65685" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 5.75" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="0 6 5.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 6 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-4 12 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 12 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 0 0.25" />
                            <Vertex pos="2 0 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 0 0.25" />
                            <Vertex pos="-2 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-4 12 5.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 12 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 0 0.25" />
                            <Vertex pos="2 0 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 0 0.25" />
                            <Vertex pos="-2 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_trim" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="24 24.25 -11.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24.25 0 0 1 -11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 6.25" />
                            <Vertex pos="6.5 0.25 5.75" />
                            <Vertex pos="6.5 -0.25 6.25" />
                            <Vertex pos="6.5 -0.25 5.75" />
                            <Vertex pos="-6.5 0.25 6.25" />
                            <Vertex pos="-6.5 0.25 5.75" />
                            <Vertex pos="-6.5 -0.25 6.25" />
                            <Vertex pos="-6.5 -0.25 5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 5.75" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="0 2 7.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -1.25" />
                            <Vertex pos="2 2 -1.75" />
                            <Vertex pos="2 -2 1.75" />
                            <Vertex pos="2 -2 1.25" />
                            <Vertex pos="-2 2 -1.25" />
                            <Vertex pos="-2 2 -1.75" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -2 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.6 0.8 -0.2" album="" material="bm_friction_grass" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.6 -0.8 -0.2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="4 2 8.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 2 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="4 -2 8.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -2 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -5.65685" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="0 -2 8.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -2 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="6 -6 0.25" />
                            <Vertex pos="6 -6 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="4 -2 3.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -2 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 5" />
                            <Vertex pos="2 2 -9" />
                            <Vertex pos="2 -2 5" />
                            <Vertex pos="2 -2 -9" />
                            <Vertex pos="-2 2 5" />
                            <Vertex pos="-2 2 -9" />
                            <Vertex pos="-2 -2 5" />
                            <Vertex pos="-2 -2 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1536 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -2048 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="6 -8 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -8 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 15 3" />
                            <Vertex pos="0 15 2" />
                            <Vertex pos="0 14 2" />
                            <Vertex pos="0 14 1" />
                            <Vertex pos="-2 15 3" />
                            <Vertex pos="-2 15 2" />
                            <Vertex pos="-2 14 2" />
                            <Vertex pos="-2 14 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -15" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 14" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 8.48528" album="Blasted" material="bm_friction_sand" texgens="1 0 0 1536 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -9.19239" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="6 -8 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -8 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 16 2" />
                            <Vertex pos="0 16 1" />
                            <Vertex pos="0 15 3" />
                            <Vertex pos="0 15 2" />
                            <Vertex pos="-2 16 2" />
                            <Vertex pos="-2 16 1" />
                            <Vertex pos="-2 15 3" />
                            <Vertex pos="-2 15 2" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 15" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -12.7279" album="Blasted" material="bm_friction_sand" texgens="1 0 0 1536 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 12.0208" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="12 -13.5 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -13.5 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 15 3" />
                            <Vertex pos="0 15 2" />
                            <Vertex pos="0 14 2" />
                            <Vertex pos="0 14 1" />
                            <Vertex pos="-2 15 3" />
                            <Vertex pos="-2 15 2" />
                            <Vertex pos="-2 14 2" />
                            <Vertex pos="-2 14 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -15" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 14" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 8.48528" album="Blasted" material="bm_friction_sand" texgens="1 0 0 3072 0 -1 0 3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -9.19239" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="12 -13.5 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -13.5 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 16 2" />
                            <Vertex pos="0 16 1" />
                            <Vertex pos="0 15 3" />
                            <Vertex pos="0 15 2" />
                            <Vertex pos="-2 16 2" />
                            <Vertex pos="-2 16 1" />
                            <Vertex pos="-2 15 3" />
                            <Vertex pos="-2 15 2" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 15" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -12.7279" album="Blasted" material="bm_friction_sand" texgens="1 0 0 3072 0 -1 0 3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 12.0208" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="12 4 -22" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 4 0 0 1 -22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 -6" />
                            <Vertex pos="2 4 -10" />
                            <Vertex pos="2 -8 -6" />
                            <Vertex pos="2 -8 -10" />
                            <Vertex pos="-10 4 -6" />
                            <Vertex pos="-10 4 -10" />
                            <Vertex pos="-10 -8 -6" />
                            <Vertex pos="-10 -8 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
